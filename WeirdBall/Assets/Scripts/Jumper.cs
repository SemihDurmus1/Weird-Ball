using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public float jumpForce = 10f; // Z�plama g�c�



    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            Quaternion jumpRotation = this.gameObject.transform.rotation; // Girdi�i nesnenin rotation bilgisi
            Vector3 jumpDirection = jumpRotation * Vector3.up; // Girdi�i nesnenin bakt��� y�ne do�ru vekt�r
            other.gameObject.GetComponent<Rigidbody>().AddForce(jumpDirection * jumpForce, ForceMode.Impulse);
        }
           
    }
}
