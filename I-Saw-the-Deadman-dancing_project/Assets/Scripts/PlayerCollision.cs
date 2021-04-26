using UnityEngine;
using DG.Tweening;

#pragma warning disable 0649
public class PlayerCollision : MonoBehaviour
{
    public UILife uilife;
    Camera cam;
    Rigidbody2D rb;
    public DisplayMessage dm;
    GameObject rep;
    [SerializeField] int collisionNb = 0;
    [SerializeField] float invicibleTime = 1.5f;

    [SerializeField] SpriteRenderer shield;
    Color startCol;
    Color endCol;


    [SerializeField] AudioHighPassFilter highPass = null;
    float hpVal;
    float hpValBase;
    [SerializeField] float hpValWhenHit;
    [SerializeField] AudioLowPassFilter lowPass;
    float lpVal;
    float lpValBase;
    [SerializeField] float lpValWhenHit;
    AudioSource boom;
    ScoreSystem scoreS;
    bool canCol = true;
    float[] pp = { 0.38f, 0.44f, 0.51f, 0.61f };

    Vector3 CameraBasePosition = new Vector3(0, 0, -5);

    private void Start()
    {
        rep = GameObject.FindGameObjectWithTag("RRRR");
        rep.SetActive(false);
        scoreS = FindObjectOfType<ScoreSystem>();
        boom = GetComponent<AudioSource>();
        cam =  Camera.main;
        rb = GetComponent<Rigidbody2D>();
        startCol = shield.color;
        endCol = shield.color;
        startCol.a = 0.9f;
        endCol.a = 0;
        hpValBase = highPass.cutoffFrequency;
        lpValBase = lowPass.cutoffFrequency;
        hpVal = hpValBase;
        lpVal = lpValBase;
        uilife = GetComponentInChildren<UILife>();
    }

    private void Update()
    {
        highPass.cutoffFrequency = hpVal;
        lowPass.cutoffFrequency = lpVal;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collisionMine();
    }

    void collisionMine()
    {
        if (!scoreS)
        {
            scoreS = FindObjectOfType<ScoreSystem>();
        }
        if (canCol)
        {
            canCol = false;
            boom.Play();
            cam.DOShakePosition(0.1f, 0.5f).OnComplete(() => { cam.transform.position = CameraBasePosition; });
            collisionNb++;
            rb.simulated = false;
            shield.color = startCol;
            hpVal = hpValWhenHit;
            lpVal = lpValWhenHit;
            DOTween.To(() => hpVal, x => hpVal = x, hpValBase, invicibleTime);
            DOTween.To(() => lpVal, x => lpVal = x, lpValBase, invicibleTime);
            shield.DOColor(endCol, invicibleTime).SetEase(Ease.InQuint);
            scoreS.hited();
            Invoke("wakeUp", invicibleTime);
            boom.pitch = pp[Random.Range(0, 4)];
            if (scoreS.hasUI && scoreS.haveLifes)
            {
                uilife.loseLife();
            }
            if (scoreS.haveLifes && scoreS.isDead)
            {
                isDead();
            }
        }
    }

    void isDead()
    {
        shield.color = endCol;
        Time.timeScale = 0;
        dm.DisplayMsg("Game Over");
        Destroy(GetComponent<MouseFollow>());
        rep.SetActive(true);
    }

    void wakeUp()
    {
        rb.simulated = true;
        canCol = true;
    }

}
