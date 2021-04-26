using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATAT : MonoBehaviour
{

    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void GoOut()
    {
        anim.Play("comminOut");
    }

    public void GoIn()
    {
        anim.Play("commingIn");
    }
}
