using System.Collections;
using System.IO;
using System.Net;
using UnityEngine;
using UnityEngine.Networking;

public class ScreenCapturer : MonoBehaviour
{
    private SpriteRenderer rend = null;
    string path;

    private void Start()
    {
        path = Application.dataPath + "/SomeLevel.png";
        rend = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
           StartCoroutine( SaveImage());
            
    }

    IEnumerator SaveImage()
    {
        yield return new WaitForEndOfFrame();
        ScreenCapture.CaptureScreenshot(path);
        while (!File.Exists(path)) {
            yield return new WaitForSeconds(0.1f);
        }
        /*
        WWW www = new WWW(path);
        while (!www.isDone)
            yield return null;
        Texture2D myTexture = www.texture;
        */
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(path);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            Texture2D myTexture = ((DownloadHandlerTexture)www.downloadHandler).texture;
            //www.LoadImageIntoTexture(myTexture);
            rend.sprite = Sprite.Create(myTexture, new Rect(0, 0, myTexture.width, myTexture.height), new Vector2(0.5f, 0.5f));
            File.Delete(path);
        }

    }

}
