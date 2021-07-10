using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeObstackle : MonoBehaviour
{
    private Rigidbody[] _cubeRigidBody;
    private Transform[] _cubeTransform;
    public float[] _randomRangeNumber;
    public float _cubeTransformTemp;

    public float _speed;

    private void Awake()
    {
        
    }

    void Start()
    {
        _cubeRigidBody = new Rigidbody[25];
        _cubeTransform = new Transform[25];
        RandomRangeArray();

        for (int i = 0; i < 25; i++)
        {
            _cubeRigidBody[i] = transform.GetChild(i).gameObject.GetComponent<Rigidbody>();
            _cubeTransform[i] = transform.GetChild(i).gameObject.GetComponent<Transform>();
        }
        _cubeTransformTemp = _cubeTransform[0].transform.position.y;
        //Debug.Log(_cubeTransform[0].position.y);
    }

    
    void FixedUpdate()
    {
        for(int i = 0; i < 25; i++)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                //if (_cubeTransform[i].position.y < _cubeTransformTemp.position.y + _randomRangeNumber[i]) stagleniyor

                if (_cubeTransform[i].position.y <  _randomRangeNumber[i] + _cubeTransformTemp)
                {
                    _cubeRigidBody[i].velocity = Vector3.up * _speed*Time.deltaTime;
                    Debug.Log(_cubeTransformTemp);
                    
                }
                else
                {
                    _cubeRigidBody[i].velocity = Vector3.zero*Time.deltaTime;
                }
            }
            else
            {
                if (_cubeTransform[i].position.y > _cubeTransformTemp)
                {
                    _cubeRigidBody[i].velocity = Vector3.down * _speed*Time.deltaTime;
                }
                else
                {
                    _cubeRigidBody[i].velocity = Vector3.zero*Time.deltaTime;
                }
            }
        }
        
    }

    private void RandomRangeArray()
    {
        _randomRangeNumber = new float[25];
        for (int j = 0; j < 25; j++)
        {
            _randomRangeNumber[j] = Random.Range(1f, 5f);
        }
    }
}
