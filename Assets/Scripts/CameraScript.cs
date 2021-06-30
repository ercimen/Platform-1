using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private Vector3 _cameraOffset;
    [SerializeField] private Vector3 _desiredPosition;
    [SerializeField] private float _smoothed;

    [SerializeField] private bool _isFollowCam;
    [SerializeField] private bool _isLastPose;

    public CharacterMovement _characterMovement;

    [SerializeField] private Transform _initialCam;

    private void Start()
    {
        
    }
    private void LateUpdate()
    {
        if(_characterMovement._isFollowCam && GameManager.Instance.isLevelStarted==false)
        {
            InitialCam();
        }
        if (_characterMovement. _isFollowCam&& GameManager.Instance.isLevelStarted)
        {
            FollowCam();
        }
        if (_characterMovement. _isLastPose&& GameManager.Instance.isLevelStarted)
        {
            LastPose();
        }
        
    }  


    void FollowCam()
    {
        _desiredPosition = _player.transform.position + _cameraOffset;
        transform.position = Vector3.Lerp(transform.position, _desiredPosition, _smoothed);
        transform.LookAt(_player.transform);
        Debug.Log("followcam");
    }
    void LastPose()
    {
        transform.LookAt(_player.transform, Vector3.left);
        Debug.Log("lastpose");
    } 
    void InitialCam()
    {
        Debug.Log("initial cam00");
        transform.position = _initialCam.position;
        transform.LookAt(_player.transform);
    }
}
