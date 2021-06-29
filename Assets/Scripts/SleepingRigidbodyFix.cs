using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepingRigidbodyFix : MonoBehaviour
{
   public Rigidbody rigidbody;
    //Kinematik rigidbody belirli bir süre etkileþim olmadýðý takdirde collisionlarý yok sayýyor. Bu kodda oyun baþladýðýnda kinematik elemanlar tetikleniyor.
   
    private void FixedUpdate()
    {
        if (GameManager.Instance.isLevelStarted)
        {
            rigidbody.MovePosition(rigidbody.position);
        }
    }
}
