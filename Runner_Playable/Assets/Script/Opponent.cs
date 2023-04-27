using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Opponent : MonoBehaviour
{
    public NavMeshAgent OpponentAgent;
    public GameObject Target;
    Vector3 OpponentStartPos;
    


   private void Start()
    {
        OpponentAgent = GetComponent<NavMeshAgent>();
        OpponentStartPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    private void Update()
    {
        OpponentAgent.SetDestination(Target.transform.position);
        if(GameManager.instance.isGameOver)
        {
            StopAgent();
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            transform.position = OpponentStartPos;
        }
    }


    void StopAgent()
    {
        OpponentAgent.Stop();
    }
}
