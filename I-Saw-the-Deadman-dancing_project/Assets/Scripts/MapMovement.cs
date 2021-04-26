using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MapMovement : MonoBehaviour
{

    public Transform destination;
    public float time;

    private void OnEnable()
    {
        Debug.Log("yo");
        transform.DOMoveX(destination.position.x, time).SetEase(Ease.Linear);
    }
}
