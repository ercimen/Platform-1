using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeObstackle : MonoBehaviour
{

    //private int[] _randomNumber = new int[25];

    private Rigidbody[] _cubeRigidBody;
    private Transform[] _cubeTransform;
    public float[] _randomRangeNumber;

    public float _speed;
    

    void Start()
    {
        //RandomNumberCreator();

        _cubeRigidBody = new Rigidbody[25];
        _cubeTransform = new Transform[25];
        RandomRangeArray();

        for(int i = 0; i <25; i++)
        {
            _cubeRigidBody[i] = transform.GetChild(i).gameObject.GetComponent<Rigidbody>();
            _cubeTransform[i] = transform.GetChild(i).gameObject.GetComponent<Transform>();
        }
    }

    
    void Update()
    {
        for(int i = 0; i < 25; i++)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                if (_cubeTransform[i].position.y < _randomRangeNumber[i])
                {
                    _cubeRigidBody[i].velocity = Vector3.up * _speed;
                    
                }
                else
                {
                    _cubeRigidBody[i].velocity = Vector3.zero;
                }
            }
            else
            {
                if (_cubeTransform[i].position.y > 3)
                {
                    _cubeRigidBody[i].velocity = Vector3.down * _speed;
                }
                else
                {
                    _cubeRigidBody[i].velocity = Vector3.zero;
                }
            }
        }
        
    }

    private void RandomRangeArray()
    {
        _randomRangeNumber = new float[25];
        for (int i = 0; i < 25; i++)
        {
            _randomRangeNumber[i] = Random.Range(3f, 8f);
        }
    }
    /**
    private void RandomNumberCreator()
    {
        for(int i = 0; i<25;i++)
        {
            _randomNumber[i] = i;
        }
        for(int i = 0; i < 25; i++)
        {
            int random = Random.Range(0, 25);
            int _tempNumber = _randomNumber[random];
            _randomNumber[random] = _randomNumber[i];
            _randomNumber[i] = _tempNumber;

        }
    }
    **/
}
