using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorMovement : MonoBehaviour
{
    public float hiz;
    public Rigidbody oyuncuRigidbody;
    public Collider engelCollider;

    private void FixedUpdate() {
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");

        Vector3 hareket = new Vector3(yatay, 0f, dikey);
        oyuncuRigidbody.AddForce(hareket * hiz);
    }

    private void OnTriggerStay(Collider other) {
        if (other == engelCollider) {
            oyuncuRigidbody.AddForce(transform.forward * 10f, ForceMode.Impulse);
            Quaternion yeniRotasyon = Quaternion.Euler(transform.rotation.eulerAngles.x, 90f, transform.rotation.eulerAngles.z);
            transform.rotation = yeniRotasyon;
        }
    }
}
