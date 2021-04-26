using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class MenuButtons : MonoBehaviour
{

    ScoreSystem ss;

    public GameObject lifeImage;
    public GameObject uiImage;
    public GameObject smallImage;
    public GameObject soundImage;
    public RectTransform rt;

    bool lifesB = false;
    bool uiB = false;
    bool smallB = false;
    bool soundB = false;

    void Start()
    {
        ss = FindObjectOfType<ScoreSystem>();
    }


    private void Update()
    {
        if (lifesB) lifeImage.SetActive(true); else lifeImage.SetActive(false);
        if (uiB) uiImage.SetActive(true); else uiImage.SetActive(false);
        if (smallB) smallImage.SetActive(true); else smallImage.SetActive(false);
        if (soundB) soundImage.SetActive(true); else soundImage.SetActive(false);
    }


    public void lifes()
    {
        if (lifesB)
        {
            ss.haveLifes = false;
            ss.baseComboMultiplier = 1;

            lifesB = false;
        } else
        {
            ss.haveLifes = true;
            ss.lives = 3;
            ss.baseComboMultiplier = 5;
            lifesB = true;
        }
    }

    public void ui()
    {
        if (uiB)
        {
            ss.hasUI = false;
            ss.finalScoreAdd += 5000;
            uiB = false;
        }
        else
        {
            ss.hasUI = true;
            ss.finalScoreAdd += -5000;
            uiB = true;
        }
    }

    public void sound()
    {
        if (soundB)
        {
            ss.hasSound = true;
            ss.finalScoreAdd += -10000;
            soundB = false;
        }
        else
        {
            ss.hasSound = false;
            ss.finalScoreAdd += 10000;
            soundB = true;
        }
    }

    public void small()
    {
        if (smallB)
        {
            ss.isSmaller = false;
            ss.maxCombo = int.MaxValue;
            smallB = false;
        }
        else
        {
            ss.isSmaller = true;
            ss.maxCombo = 3;
            smallB = true;
        }
    }

    public void play()
    {
        rt.DOMoveX(-1700, 4.5f).SetEase(Ease.Linear).OnComplete(() => { SceneManager.LoadScene("Game"); });
    }

    public void exit()
    {
        Application.Quit();
    }

}
