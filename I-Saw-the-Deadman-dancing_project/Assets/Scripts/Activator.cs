using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{

    public GameObject thing;

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
            thing.SetActive(true);
    }
}
