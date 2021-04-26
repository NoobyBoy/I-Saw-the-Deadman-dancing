using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnStart : MonoBehaviour
{
    void Update()
    {
        ScoreSystem sc = FindObjectOfType<ScoreSystem>();
        if (sc)
        {
            if (!sc.hasSound)
                GetComponent<AudioSource>().volume = 0;
            Destroy(this);
        }

    }


}
