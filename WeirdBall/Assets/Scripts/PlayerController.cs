using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rigidBody;
    public float speed = 0.5f;
    [SerializeField] SphereCollider sphereCollider;

    void Start()
    {
        Physics.gravity *= 4f;
        rigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");
        Vector3 yon = new Vector3(yatay, 0f, dikey);
        yon = Quaternion.Euler(0, 45, 0) * yon;

        if (yon.magnitude > 0.1f)
        {
            rigidBody.AddForce(yon.normalized * speed, ForceMode.Impulse);
        }
    }
}
