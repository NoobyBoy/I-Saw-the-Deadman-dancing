using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonSfx : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
{

    SoundDB db;

    private void Start()
    {
        db = GameObject.FindObjectOfType<SoundDB>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        db.hover.Play();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        db.click.Play();
    }

}