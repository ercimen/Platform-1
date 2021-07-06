using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ters_cube : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public bool ters;

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ters = true;
            rb.velocity = Vector3.up * -speed;
        }

        if (Input.GetKey(KeyCode.E))
        {
            ters = false;
            rb.velocity = Vector3.up * speed;
        }
    }

}
