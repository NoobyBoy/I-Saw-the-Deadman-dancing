using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Spawner : MonoBehaviour
{
    public GameObject tactac;
    public float repeatRate = 0.23f;
    public float offset = 0f;
    public Transform papa;
    public Pooler p;

    private void OnEnable()
    {
        InvokeRepeating("LaunchProjectile", offset, repeatRate);
    }


    private void OnDisable()
    {
        CancelInvoke();
    }

    void LaunchProjectile()
    {
       p.SpawnFromPool(papa.position, papa.rotation);
    }

}
