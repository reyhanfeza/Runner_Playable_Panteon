using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HalfDonut1 : MonoBehaviour
{
public float speed = 2.0f; 
public float distance = 1f; 

private Vector3 startPos; 

    void Start ()
    {
       startPos = transform.position;

        transform.DOMoveX(startPos.x - distance, speed).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo); 
    }
}



