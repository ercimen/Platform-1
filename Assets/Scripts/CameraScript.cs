using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _playerModel;

    [SerializeField] private Vector3 _cameraOffset;
    [SerializeField] private Vector3 _desiredPosition;
    [SerializeField] private float _smoothed;

    public CharacterMovement _characterMovement;

    [SerializeField] private Transform _initialCam;
    [SerializeField] private Transform _cameraPivot;

    public float _rotateY,_rotateX,_rotateSpeed,_totalRotate;


    private void LateUpdate()
    {
        if(CharacterMovement.instance._isFollowCam && GameManager.Instance.isLevelStarted==false)
        {
            InitialCam();
        }
        if (CharacterMovement.instance._isFollowCam && GameManager.Instance.isLevelStarted)
        {
            FollowCam();
        }
        if (CharacterMovement.instance._isLastPose && GameManager.Instance.isLevelStarted)
        {
            LastPose();
        }
        
    }

    void InitialCam()
    {
       transform.position = _initialCam.position;
       
    }
    void FollowCam()
    {
        _desiredPosition = new Vector3(0.78f, 10.06f, _player. transform.position.z) + _cameraOffset;
        transform.position = Vector3.Lerp(transform.position, _desiredPosition, _smoothed);
        transform.eulerAngles = new Vector3(28.4f, -47.2f, 0);
    }
    void LastPose()
    {
        
        if(_rotateY < _totalRotate)
        {
        _rotateY += _rotateSpeed;
        
        transform.LookAt(_cameraPivot);
        Quaternion QT = Quaternion.Euler(_rotateX, _rotateY, 0);
       _cameraPivot.rotation = Quaternion.Lerp(_cameraPivot.rotation, QT, Time.deltaTime * .5f);
        
        }
        

    } 
}
