using UnityEngine;
using UnityEngine.SceneManagement;


public class ToOutro : MonoBehaviour
{
    private void OnEnable()
    {
        DontDestroyOnLoad(this.gameObject);
        foreach (Transform t in transform)
        {
            Destroy(t.gameObject);
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
