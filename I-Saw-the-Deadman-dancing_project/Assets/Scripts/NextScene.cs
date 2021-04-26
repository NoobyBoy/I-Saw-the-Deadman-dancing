using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{

    private void OnEnable()
    {
        if (System.IO.File.Exists("YesYouDidIt.congratulation"))
        {
            SceneManager.LoadScene("Menu");

        }else
        {
            SceneManager.LoadScene("Game");
        }
    }

}
