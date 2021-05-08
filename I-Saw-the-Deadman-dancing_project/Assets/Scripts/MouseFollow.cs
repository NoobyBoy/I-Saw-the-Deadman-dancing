using UnityEngine;
using DG.Tweening;

public class MouseFollow : MonoBehaviour
{
    Vector3 mousePos;
    Camera cam;
    public bool control = true;
    public float timeToCenter;

    private void Start()
    {
        cam = Camera.main;
        Cursor.lockState = CursorLockMode.Locked;
        Invoke("unlock", 0.5f);
    }

    void Update()
    {
        if (control)
        {
            Cursor.visible = false;
            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            transform.position = mousePos;
            Vector3 pos = cam.WorldToViewportPoint(transform.position);
            pos.x = Mathf.Clamp01(pos.x);
            pos.y = Mathf.Clamp01(pos.y);
            transform.position = cam.ViewportToWorldPoint(pos);
        } else
        {
            Cursor.visible = true;
        }
    }
    private void OnDisable()
    {
        Cursor.visible = true;
    }

    void unlock()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void loseControle()
    {
        control = false;
        transform.DOMove(Vector3.zero, timeToCenter);
        Invoke("shaka", timeToCenter + 8);

    }

    void shaka()
    {
        cam.DOShakePosition(20, 1, 3);
    }
}
