using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoodiShooter : MonoBehaviour
{

    public GameObject projetcile;
    public Transform spawnRef;
    public Pooler pooler;

    public void Shoot()
    {
        pooler.SpawnFromPool( spawnRef.position, spawnRef.rotation);
    }
}
