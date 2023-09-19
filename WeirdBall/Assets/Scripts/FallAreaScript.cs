using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallAreaScript : MonoBehaviour
{
    [SerializeField] SphereCollider player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Debug.Log("girdi");
            player.isTrigger = true;
            Invoke("DisableTrigger", 0.5f);
        }
    }
    void DisableTrigger()
    {
        player.isTrigger = false;
    }
}