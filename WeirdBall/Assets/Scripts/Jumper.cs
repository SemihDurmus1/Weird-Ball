using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public float jumpForce = 10f; // Zýplama gücü



    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            Quaternion jumpRotation = this.gameObject.transform.rotation; // Girdiði nesnenin rotation bilgisi
            Vector3 jumpDirection = jumpRotation * Vector3.up; // Girdiði nesnenin baktýðý yöne doðru vektör
            other.gameObject.GetComponent<Rigidbody>().AddForce(jumpDirection * jumpForce, ForceMode.Impulse);
        }
           
    }
}
