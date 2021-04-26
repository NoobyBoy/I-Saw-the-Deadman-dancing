using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleOnStart : MonoBehaviour
{
    void Update()
    {
        ScoreSystem ss = FindObjectOfType<ScoreSystem>();
        if (ss)
        {
            if (ss.isSmaller)
            {
                this.transform.localScale = new Vector3(0.10f, 0.10f, 1);
            }
            Destroy(this);
        }
    }


}
