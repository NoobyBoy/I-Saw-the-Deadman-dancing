using SensorToolkit;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreSystem : MonoBehaviour
{

    RangeSensor2D sensor;
    bool activated = false;
    public Transform player = null;
    public uint score = 0;
    public int comboMultiplier = 1;
    public int hiteNb = 0;
    public int hitMalus = 2000;
    public float comboAvg = 1;


    public bool isDead = false;
    public bool haveLifes;
    public int lives = 3;
    public int baseComboMultiplier = 1;

    public bool isSmaller;
    public int maxCombo = int.MaxValue;

    public bool hasUI;
    public bool hasSound;
    public int finalScoreAdd;

    [SerializeField] float staticZone = 1;
    Vector3 begPrevious = new Vector3(99, 99, 99);
    Vector3 previous;
    [SerializeField] float renewTime = 0;
    List<Vector3> lastPos = new List<Vector3>();

    //distance
    float distance = 0;

    //
    float elapsedTimeSinceUpdate = 0;
    float averageDistance = 0;

    // danger counter
     int dangerCounter = 0;


    //comboMultiplier
    float comboOffset = 5;
    float comboTime = 0;
    long comboTotal;
    float comboIt;

    bool hasEnteredGame = false;

    public uint add = 0;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        if (SceneManager.GetSceneByName("Game").isLoaded && !hasEnteredGame)
        {
            getPlayer();
        } else if (!SceneManager.GetSceneByName("Game").isLoaded && hasEnteredGame)
        {
            hasEnteredGame = false;
        }
        if (activated)
        {
            elapsedTimeSinceUpdate += Time.deltaTime;
            if (elapsedTimeSinceUpdate > 0.2)
            {
                updateList();
                calcAverage();
                updateCombo();
                calcDistance();
                dangerCounter = sensor.DetectedObjects.Count;
                add = (uint)(((int)distance * comboMultiplier) + (dangerCounter * comboMultiplier)) * 10;
                score += add;
                previous = player.transform.position;
                elapsedTimeSinceUpdate = 0;
            }
        }
    }
    
    void getPlayer()
    {
        try
        {
            lives = 3;
            isDead = false;
            player = GameObject.FindGameObjectWithTag("Player").transform;
            //player.gameObject.SetActive(false);
            if (player)
                sensor = player.GetComponent<RangeSensor2D>();
            hasEnteredGame = true;
            if (hasUI)
            {
                GameObject.FindGameObjectWithTag("ATUI").SetActive(true);
            }
        } catch (NullReferenceException)
        {
        }


    }

    public void hited()
    {
        comboMultiplier = 1;
        comboTime = 0;
        hiteNb++;
        lives--;
        if (lives == 0) isDead = true;
    }

    void updateList()
    {
        int max = (int)(5 * renewTime);
        if (lastPos.Count > max)
        {
            lastPos.RemoveAt(0);
            lastPos.Add(previous);
        }
        else if (previous != begPrevious)
        {
            lastPos.Add(previous);
        }
    }

    void calcAverage()
    {
        float total = 0;
        int c = 0;
        foreach (Vector3 v in lastPos)
        {
            total += Vector3.Distance(player.transform.position, v);
            c++;
        }
        averageDistance = total / c;
    }

    void calcDistance()
    {
        if (previous != begPrevious)
        {
            distance = Vector3.Distance(player.transform.position, previous);
        }
    }

    void updateCombo()
    {
        comboTime += 0.2f;
        if (averageDistance < staticZone)
        {
            comboMultiplier = baseComboMultiplier;
        }
        else if (comboTime > comboOffset)
        {
                comboTime = 0;
                comboMultiplier++;
        }
        if (comboMultiplier > maxCombo) comboMultiplier = maxCombo;
        comboTotal += comboMultiplier;
        comboIt++;
        comboAvg = comboTotal / comboIt;
    }

    public void SignalActivate()
    {
        previous = begPrevious;
        activated = true;
    }

    public void SignalDeasctivate()
    {
        activated = false;
        hasEnteredGame = false;
    }

    private void OnDrawGizmos()
    {
        if (player)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawWireSphere(player.transform.position, staticZone);
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(player.transform.position, averageDistance);
        }
    }
}
