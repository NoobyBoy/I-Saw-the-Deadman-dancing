using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class ChangeTextOnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public TextMeshProUGUI desc;
    public TextMeshProUGUI effect;
    public string descriptionString;
    public string effectString;
    public Color EffectColor;

    public void OnPointerEnter(PointerEventData eventData)
    {
        desc.SetText(descriptionString);
        effect.color = EffectColor;
        effect.SetText(effectString);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        desc.SetText("Choose your Modificator(s)          (Or Not)");
        effect.SetText("");
    }

}
