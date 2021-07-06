using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2 : MonoBehaviour
{
    public Rigidbody rb;
    public bool ters;
    void Start()
    {
        
    }

    void Update()
    {
        if (ters==true)
        {
            transform.Rotate(new Vector3(1f, 0f, 0f));
        }
        if (ters==false)
        {
            transform.Rotate(new Vector3(-1f, 0f, 0f));
        }
    }

}
