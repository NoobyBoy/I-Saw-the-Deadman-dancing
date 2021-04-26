using UnityEngine;
using TMPro;

public class setScore : MonoBehaviour
{
    public TextMeshProUGUI total;
    public TextMeshProUGUI distance;
    public TextMeshProUGUI combo;
    public TextMeshProUGUI hits;
    public TextMeshProUGUI mod;

    void Start()
    {
        ScoreSystem ss = GameObject.FindObjectOfType<ScoreSystem>();
        if (ss)
        {
            distance.SetText(ss.score.ToString());
            combo.SetText((Mathf.Floor(ss.comboAvg * 100) / 100).ToString() + " x  1000");
            hits.SetText(ss.hiteNb.ToString() + " x  -" + ss.hitMalus.ToString());
            mod.SetText(ss.finalScoreAdd.ToString());

            long tt = ss.score + (int)((Mathf.Floor(ss.comboAvg * 100) / 100) * 1000) - (ss.hiteNb * ss.hitMalus) + (int)ss.finalScoreAdd;
            total.SetText(tt.ToString());
        }
    }


}
