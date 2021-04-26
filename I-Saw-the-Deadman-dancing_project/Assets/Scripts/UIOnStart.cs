using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIOnStart : MonoBehaviour
{
    public GameObject ui;
    void Update()
    {
        ScoreSystem ss = FindObjectOfType<ScoreSystem>();
        if (ss)
        {
            if (ss.hasUI)
            {
                ui.SetActive(true);
            }
            else
            {
                ui.SetActive(false);
            }
            Destroy(this);
        }
    }

    

}
