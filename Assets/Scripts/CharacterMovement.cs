using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField]  private float _speed;
    public Animator animator;


    void OnCollisionStay(Collision collision)
    {
        
        if(collision.collider.tag == ("Platform")&& GameManager.Instance.isLevelStarted)
        {
            animator.SetFloat("Speed", 1);
            transform.position += _speed * Vector3.forward * Time.deltaTime;
        }
        
        if(collision.collider.tag == "Finish"&& GameManager.Instance.isLevelStarted)
        {
             animator.SetBool("IsLevelFinish", true);
        }
    }
}
    

