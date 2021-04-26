using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPages : MonoBehaviour
{
   public void openSpotify()
    {
        Application.OpenURL("https://open.spotify.com/artist/23MFpobFT7i4ajXfVKwBCT?si=rKs2vhU1ThWz6w1pZga23g");
    }

    public void openSoundcloud()
    {
        Application.OpenURL("https://soundcloud.com/mmat25/");
    }
}
