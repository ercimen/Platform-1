using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] 
    private float _speed;
    private Rigidbody _rbPlayer;

    public Animator animator;

    private bool _playerDirectionForward;

    
    private void Update()
    {
        

        if (GameManager.Instance.isLevelStarted)
        {
            //Idle animasyonu sonlandýðýnda karakter yönünü düzeltiyor.
            if(!_playerDirectionForward)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            _playerDirectionForward = true;

            animator.SetBool("IsLevelStarted", true);

            PlayerMove();

            
        }
        
    }

    private void PlayerMove()
    {
        
        transform.position += Vector3.forward * _speed * Time.deltaTime;
    }

}
