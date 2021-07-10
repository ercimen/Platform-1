using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairObstackle : MonoBehaviour
{
    private Rigidbody[] _stairRigidBody;
    private Transform[] _stairTransform;
    private float[] _riser;
    public float _riseFactor;
    private Transform _stairTransformTemp;


    public float _speed;
    void Start()
    {
        _stairRigidBody = new Rigidbody[10];
        _stairTransform = new Transform[10];
        _riser = new float[10];
        
        

        for(int i = 0; i < 10; i++)
        {
            _stairRigidBody[i] = transform.GetChild(i).gameObject.GetComponent<Rigidbody>();
            _stairTransform[i] = transform.GetChild(i).gameObject.GetComponent<Transform>();
        }
        
        RiseCreator();
        _stairTransformTemp = _stairTransform[0];
        
        
    }


    void FixedUpdate()
    {
        for(int i = 0; i < 10; i++)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                if(_stairTransform[i].position.y < _riser[i]+_stairTransformTemp.position.y)
                {
                    _stairRigidBody[i].velocity = Vector3.up * _speed*Time.deltaTime;
                }
                else
                {
                    _stairRigidBody[i].velocity = Vector3.zero;
                }
            }
            else
            {
                if (_stairTransform[i].position.y > _stairTransformTemp.position.y)
                {
                    _stairRigidBody[i].velocity = Vector3.down * _speed*Time.deltaTime;
                }
                else
                {
                    _stairRigidBody[i].velocity = Vector3.zero;
                }
            }
        }
    }

    private void RiseCreator()
    {
        float k = 0;
        for(int i = 0; i< 10; i++)
        {
            _riser[i] =  k * _riseFactor;
            k += 1.5f;
        }
    }
}
