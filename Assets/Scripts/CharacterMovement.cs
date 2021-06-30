using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    public Animator animator;

    [SerializeField] private ParticleSystem _confettiRain;

    public bool _isFollowCam, _isLastPose, _isLevelEnd;

    private void Update()
    {
        if (_isLevelEnd)
        {
            StartCoroutine(ParticleSystemDetection());
        }
    }

    void OnCollisionStay(Collision collision)
    {

        if (collision.collider.tag == ("Platform") && GameManager.Instance.isLevelStarted)
        {
            animator.SetFloat("Speed", 1);
            transform.position += _speed * Vector3.forward * Time.deltaTime;
            _isFollowCam = true;
        }

        if (collision.collider.tag == "Finish" && GameManager.Instance.isLevelStarted)
        {
            animator.SetBool("IsLevelFinish", true);

            _isFollowCam = false;
            _isLastPose = true;


            _isLevelEnd = true;
        }
    }

    IEnumerator ParticleSystemDetection()
    {
        yield return new WaitForSeconds(7.5f);
        _confettiRain.Play();
    }
}
    

