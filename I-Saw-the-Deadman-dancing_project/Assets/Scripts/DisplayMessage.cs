using UnityEngine;
using TMPro;
using UnityEngine.UI;
using DG.Tweening;

public class DisplayMessage : MonoBehaviour
{

    public TextMeshProUGUI txt;
    public Image sp;
    Color invi = new Color( 1, 1, 1, 0 );
    Color full = new Color( 1, 1, 1, 1 );
    Color fullSp;
    Color inviSp;

    private void Start()
    {
        fullSp = inviSp = sp.color;
        inviSp.a = 0;
        txt.color = invi;
        sp.color = inviSp;
    }

    public void DisplayMsg(string str,float time=4)
    {
        txt.SetText(str);
        txt.color = full;
        sp.color = fullSp;
        txt.DOBlendableColor(invi, time).SetEase(Ease.InQuart);
        DOTween.To(() => sp.color, x => sp.color = x, inviSp, time).SetEase(Ease.InQuart);


    }

}
