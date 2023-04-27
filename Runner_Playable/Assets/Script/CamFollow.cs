using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform CameraTarget;
    public float sSpeed = 10f;
    public Vector3 dist;
    public Transform lookTarget;


    private void LateUpdate()
    {
        Vector3 dPos = CameraTarget.position + dist;
        Vector3 sPos = Vector3.Lerp(transform.position, dPos, sSpeed * Time.deltaTime);
        transform.position = sPos;
        transform.LookAt(lookTarget.position);
    }
}
