using UnityEngine;
using DG.Tweening;

public class TacTacMovement : MonoBehaviour
{
    public float speed;

    private void OnEnable()
    {
        GetComponent<Rigidbody2D>().linearVelocity = new Vector2(speed, 0);
    }


}
