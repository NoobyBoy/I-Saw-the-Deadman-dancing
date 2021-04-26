using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalForScorSystem : MonoBehaviour
{
    public DisplayMessage dm;

    public GameObject SsPref;
    public GameObject uiPlayer;
    public GameObject uiPlayer2;
    ScoreSystem ss;

    void Start()
    {
        ss = GameObject.FindObjectOfType<ScoreSystem>();
        if (!ss)
            ss = Instantiate(SsPref).GetComponent<ScoreSystem>();
    }


    public void Activate()
    {
        ss.SignalActivate();
        if (ss.hasUI)
        {
            dm.DisplayMsg("Score counting Started !");
            uiPlayer.SetActive(true);
            Invoke("dec", 0.5f);
        }
    }

    public void Deactivate()
    {
        ss.SignalDeasctivate();
        if (ss.hasUI)
        {
            uiPlayer.SetActive(false);
            uiPlayer2.SetActive(false);
        }
    }

    void dec()
    {
        uiPlayer2.SetActive(true);
    }



}
