using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField]  private float _speed;
    public Animator animator;

    public bool _isLevelEnd;
    public ParticleSystem _confettiRain;

    [Header("Camera Detection")]
    public bool _isFollowCam;
    public bool _isLastPose;

    private void Update()
    {
        if (_isLevelEnd)
        {
            StartCoroutine(ParticleSystemDetection());
            ParticleSystemDetection();
        }
    }
    void OnCollisionStay(Collision collision)
    {
        
        if(collision.collider.tag == ("Platform")&& GameManager.Instance.isLevelStarted)
        {
            animator.SetFloat("Speed", 1);
            transform.position += _speed * Vector3.forward * Time.deltaTime;

            //Use for camera script.
            _isFollowCam = true;
        }
        
        if(collision.collider.tag == "Finish"&& GameManager.Instance.isLevelStarted)
        {
             animator.SetBool("IsLevelFinish", true);

<<<<<<< Updated upstream
            //Use for camera script.
            _isFollowCam = false;
            _isLastPose = true;
=======
            
>>>>>>> Stashed changes

            _isLevelEnd = true;
        }
    }
<<<<<<< Updated upstream
    IEnumerator ParticleSystemDetection()
=======
    private void OnCollisionStay(Collision collision)
    {
        

        if(collision.collider.tag == ("Ground"))
        {
            if (GameManager.Instance.isLevelStarted)
            {
                PlayerMove();
            }
        }
        if(collision.collider.tag == ("Finish"))
        {
            animator.SetBool("IsLevelFinish", true);
        }
    }
  

    private void PlayerMove()
>>>>>>> Stashed changes
    {
        yield return new WaitForSeconds(7.5f);
        _confettiRain.Play();
    }
}
    

