using UnityEngine;
using DG.Tweening;

public class TacTacMovement : MonoBehaviour
{
    public float speed;

    private void OnEnable()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
    }


}
