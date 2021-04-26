using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILife : MonoBehaviour
{

    public GameObject l1;
    public GameObject l2;
    public GameObject l3;

    int i = 3;

    public void loseLife()
    {
        if (i ==3)
        {
            l3.SetActive(false);
        }
        if (i == 2)
        {
            l2.SetActive(false);
        }
        if (i == 1)
        {
            l1.SetActive(false);
        }
        i--;
    }

}
