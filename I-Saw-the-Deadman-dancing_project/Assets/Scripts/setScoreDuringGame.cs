using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class setScoreDuringGame : MonoBehaviour
{
    public TextMeshProUGUI distance;
    public TextMeshProUGUI combo;
    public TextMeshProUGUI hits;
    ScoreSystem ss;
   
    private void Start()
    {
       ss = GameObject.FindObjectOfType<ScoreSystem>();
    }

    void Update()
    {
        if (ss)
        {
            distance.SetText(ss.score.ToString());
            combo.SetText(ss.comboMultiplier.ToString());
            hits.SetText(ss.hiteNb.ToString());

        }
    }

}
