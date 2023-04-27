using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ShiningRotate : MonoBehaviour
{
    public float rotationSpeed = 5.0f;
     public float speed = 2.0f; 
    public float distance = 1f; 

    private Vector3 startPos; 

    void Start () {

        transform.DORotate(new Vector3(0f, 360f, 0f), rotationSpeed, RotateMode.LocalAxisAdd).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart);

       startPos = transform.position;
       transform.DOMoveX(startPos.x + distance, speed).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);

    }
}
