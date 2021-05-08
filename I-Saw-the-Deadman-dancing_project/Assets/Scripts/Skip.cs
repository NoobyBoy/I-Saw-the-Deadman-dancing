using UnityEngine;
using UnityEngine.SceneManagement;

public class Skip : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))
        {
            if (System.IO.File.Exists("YesYouDidIt.congratulation"))
            {
                SceneManager.LoadScene("Menu");

            }
            else
            {
                SceneManager.LoadScene("Game");
            }
        }
    }
}
