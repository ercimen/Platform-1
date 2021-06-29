using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepingRigidbodyFix : MonoBehaviour
{
   public Rigidbody rigidbody;
    //Kinematik rigidbody belirli bir s�re etkile�im olmad��� takdirde collisionlar� yok say�yor. Bu kodda oyun ba�lad���nda kinematik elemanlar tetikleniyor.
   
    private void FixedUpdate()
    {
        if (GameManager.Instance.isLevelStarted)
        {
            rigidbody.MovePosition(rigidbody.position);
        }
    }
}
