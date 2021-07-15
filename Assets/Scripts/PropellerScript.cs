using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerScript : MonoBehaviour
{
    public float _angularSpeed;
    public Rigidbody _rb;
  

    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _rb.angularVelocity = Vector3.right * _angularSpeed * Time.deltaTime;
        }
        else
        {
            _rb.angularVelocity = Vector3.right * -_angularSpeed * Time.deltaTime;
        }
    }
}
