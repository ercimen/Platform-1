using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPivot : MonoBehaviour
{
    public GameObject _player;
    public GameObject _playerModel;


    private void LateUpdate()
    {
        if (CharacterMovement.instance._isFollowCam && GameManager.Instance.isLevelStarted == false)
        {
            transform.position = new Vector3(0.78f, 10, _player.transform.position.z) + new Vector3(0, 0, 0);
        }
        if (CharacterMovement.instance._isFollowCam && GameManager.Instance.isLevelStarted)
        {
            transform.position = new Vector3(0.78f, 10, _player.transform.position.z) + new Vector3(0, 0, 0);
        }
        if (CharacterMovement.instance._isLastPose && GameManager.Instance.isLevelStarted)
        {
            transform.position = new Vector3(0.78f, 10, _playerModel.transform.position.z) + new Vector3(0, 0, 0);
        }
        
        
        
    }
}
