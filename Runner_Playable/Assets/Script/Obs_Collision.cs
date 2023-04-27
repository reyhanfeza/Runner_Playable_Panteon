using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Obs_Collision : MonoBehaviour
{
    Vector3 PlayerStartPos;

    private void Start()
    {
        PlayerStartPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            transform.position = PlayerStartPos;
    
        }
    }
}
