using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootMovment : MonoBehaviour
{
    public float speed;

    private void Awake()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(speed, 0, 0);
    }
}
