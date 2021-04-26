using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.3f;
    [Range(0, 360)] [SerializeField] float offset = 0;
    float yVelocity = 0.1f;

    void Update()
    {
        Vector3 diff = target.position - transform.position;
        diff.Normalize();

        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        float newPosition = Mathf.SmoothDampAngle(transform.rotation.eulerAngles.z, rot_z + offset, ref yVelocity, smoothTime);
        transform.localRotation = Quaternion.Euler(0f, 0f, newPosition);
    }

}
