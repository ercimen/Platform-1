using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kup : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public bool ters;

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rb.velocity = Vector3.up * speed;

        }

        else
        {
            rb.velocity = Vector3.up * -speed;
        }
    }
    
}
