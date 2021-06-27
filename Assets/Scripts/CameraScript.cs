using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private Vector3 _cameraOffset;
    [SerializeField] private Vector3 _desiredPosition;
    [SerializeField] private float _smoothed;

    private void LateUpdate()
    {
        _desiredPosition = _player.transform.position + _cameraOffset;
        transform.position = Vector3.Lerp(transform.position, _desiredPosition, _smoothed);
        //transform.LookAt(_player.transform, Vector3.left);
    }
}
