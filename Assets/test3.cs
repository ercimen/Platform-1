using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test3 : MonoBehaviour
{
    public float torque;
    public Rigidbody rb;
    public bool ters;
    void Start()
    {
        rb.angularVelocity = Vector3.forward * 1.0f;
    }

    void FixedUpdate()
    {           
        
        if (ters)
        {
            rb.AddTorque(transform.right * torque);
          
        }
        if (!ters)
        {
            rb.AddTorque(transform.right * -torque);
            
            
        }
        

    }
}
