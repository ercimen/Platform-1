using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private Vector3 _cameraOffset;
    [SerializeField] private Vector3 _desiredPosition;
    [SerializeField] private float _smoothed;

    [SerializeField] private CharacterMovement _characterMovement;

    


    private void LateUpdate()
    {
        if (_characterMovement._isFollowCam)
        {
            FollowCam();
        }
        if (_characterMovement._isLastPose)
        {
            LastPose();
        }
        
    }
    
    void FollowCam()
    {
        _desiredPosition = _player.transform.position + _cameraOffset;
        transform.position = Vector3.Lerp(transform.position, _desiredPosition, _smoothed);
        Debug.Log("followcam");
    }
<<<<<<< Updated upstream

    void LastPose()
    {
        transform.LookAt(_player.transform, Vector3.left);
        Debug.Log("lastpose");
    }

    
=======
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == ("Finish"))
        {

        }

    }
>>>>>>> Stashed changes
}
