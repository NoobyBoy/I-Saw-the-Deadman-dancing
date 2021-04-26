using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{

    public List<string> Dtag = new List<string>();

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Dtag.Contains(collision.gameObject.tag))
        {
            collision.gameObject.SetActive(false);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (Dtag.Contains(collision.gameObject.tag))
        {
            collision.gameObject.SetActive(false);
        }
    }
}
