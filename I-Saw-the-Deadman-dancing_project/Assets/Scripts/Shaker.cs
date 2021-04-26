using UnityEngine;
using DG.Tweening;

public class Shaker : MonoBehaviour
{
    public float dur;
    public Vector3 strength;
    public int vibrato;
    [Range (0, 90)] public float rand;

    void Start()
    {
        transform.DOShakePosition(dur, strength, vibrato, rand, false, false);
    }


}
