using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
   
    public PlayerContorller playerContorller;
    public Animator PlayerAnim;
    public GameObject Player;


    private void Start()
    {
        PlayerAnim = Player.GetComponentInChildren<Animator>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
           // PlayerFinished();
           StopAnimation();
        }
    }

    void StopAnimation()
    {
       // playerContorller.Speed = 0;
       // PlayerAnim.SetBool("Painting", true);
       PlayerAnim.Play("Running", -1, 0f);
        GameManager.instance.isGameOver = true;
    }

    
   
}
