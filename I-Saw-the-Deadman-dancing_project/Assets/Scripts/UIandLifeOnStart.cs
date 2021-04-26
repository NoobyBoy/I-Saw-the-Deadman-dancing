using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIandLifeOnStart : MonoBehaviour
{
    public GameObject ui;
    void Update()
    {
        ScoreSystem ss = FindObjectOfType<ScoreSystem>();
        if (ss)
        {
            if (ss.hasUI && ss.haveLifes)
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


