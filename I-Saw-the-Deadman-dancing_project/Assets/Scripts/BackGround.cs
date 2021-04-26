using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public float dest;
    public float rest;

    void OnEnable()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(speed, 0, 0);
    }

    private void Update()   
    {
        if (transform.position.x <= dest)
        {
            transform.position = new Vector3(rest, transform.position.y, transform.position.z);
        }
    }

}
