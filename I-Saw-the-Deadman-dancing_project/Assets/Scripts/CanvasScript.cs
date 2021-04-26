using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
public class CanvasScript : MonoBehaviour
{
    public GameObject sc;
    public GameObject cr;
    public TextMeshProUGUI txt;

    bool isscore = true;

    public void switchh() {
        if (isscore)
        {
            sc.SetActive(false);
            cr.SetActive(true);
            txt.SetText("Score");
        } else
        {
            cr.SetActive(false);
            sc.SetActive(true);
            txt.SetText("Credits");
        }
        isscore = !isscore;
    }

    public void exit()
    {
        Application.Quit();
    }

    public void replay()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    public void replayForReal()
    {
        SceneManager.LoadScene("Empty", LoadSceneMode.Single);
    }

    public void menu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);

    }

}
