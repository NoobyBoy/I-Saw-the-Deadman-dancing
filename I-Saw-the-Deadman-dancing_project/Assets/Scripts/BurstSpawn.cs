using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurstSpawn : MonoBehaviour
{
    public GameObject tactac;
    public float repeatRate = 0.23f;
    public float offset = 0f;
    public Transform papa;

    public Pooler pooler;

    public float burstRate;
    public int burstSize;

    private void OnEnable()
    {
        InvokeRepeating("Burst", offset, repeatRate);
    }


    private void OnDisable()
    {
        CancelInvoke();
    }

    void Burst()
    {
        for (int i = 0; i < burstSize; ++i)
        {
            Invoke("LaunchProjectile", burstRate * (i + 1));
        }
    }

    public void StopRepeat()
    {
        CancelInvoke();
    }

    public void LaunchProjectile()
    {
        pooler.SpawnFromPool(papa.position, papa.rotation);
    }
}
