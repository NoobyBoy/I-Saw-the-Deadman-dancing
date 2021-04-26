using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetScore : MonoBehaviour
{

    ScoreSystem ss;
    public TextMeshProUGUI t;

    void Start()
    {
        ss = GameObject.FindObjectOfType<ScoreSystem>();
    }

    public void get()
    {
        t.SetText(ss.add.ToString());
    }

}
