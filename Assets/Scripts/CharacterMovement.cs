using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [Header("Player Physics")]
    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private float _speed;

    [Header("Animator")]
    public Animator animator;
    public static CharacterMovement instance;
    public bool _isFollowCam, _isLastPose, _isLevelEnd;

    [Header ("Confetti")]
    [SerializeField] private ParticleSystem _confettiRain;
    [SerializeField] private float _confettiRainDistance;

    void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        if (_isLevelEnd)
        {
            StartCoroutine(ParticleSystemDetection());
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == ("Platform"))
            {
            _isFollowCam = true;

        }

        if (collision.collider.tag == ("Platform") && GameManager.Instance.isLevelStarted)
        {
            animator.SetFloat("Speed", 1);
            _rigidBody.velocity = _speed * Vector3.forward;
            _isFollowCam = true;
        }

        if (collision.collider.tag == "Finish" && GameManager.Instance.isLevelStarted)
        {
            animator.SetBool("IsLevelFinish", true);

            _isFollowCam = false;
            _isLastPose = true;


            _isLevelEnd = true;
        }
        if (collision.collider.tag == "Border")
        {
            GameManager.Instance.GameOver();
        }

    }

    IEnumerator ParticleSystemDetection()
    {
       
        _confettiRain.transform.position = this.transform.GetChild(0).gameObject.transform.position + new Vector3(_confettiRainDistance,0,0);
        yield return new WaitForSeconds(7.5f);
        GameManager.Instance.NextLevelPanel();
        _confettiRain.Play();
    }
}
    

