using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.position += Vector3.forward * _speed*Time.deltaTime;
    }

}
