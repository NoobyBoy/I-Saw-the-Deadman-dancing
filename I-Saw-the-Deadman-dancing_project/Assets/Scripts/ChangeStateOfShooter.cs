using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeStateOfShooter : MonoBehaviour
{

    public GameObject sp1;
    public GameObject sp2;
    public GameObject sp3;
    public GameObject sp4;
    BurstSpawn b1;
    BurstSpawn b2;
    BurstSpawn b3;
    BurstSpawn b4;
    int i = 0;

    private void Start()
    {
        b1 = sp1.GetComponent<BurstSpawn>();
        b2 = sp2.GetComponent<BurstSpawn>();
        b3 = sp3.GetComponent<BurstSpawn>();
        b4 = sp4.GetComponent<BurstSpawn>();
    }

    public void ChangeState()
    {

        b1.StopRepeat();
        b2.StopRepeat();
        b3.StopRepeat();
        b4.StopRepeat();
    }

    public void Shoot()
    {
        if (i == 0)
            b1.LaunchProjectile();
        if (i == 1)
            b2.LaunchProjectile();
        if (i == 2)
            b3.LaunchProjectile();
        if (i == 3)
            b4.LaunchProjectile();

        i = (i + 1) % 2;
    }

}
