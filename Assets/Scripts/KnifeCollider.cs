using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeCollider : MonoBehaviour
{
    void GetHit(string colliderTag)
    {
       // if (colliderTag.Equals("Plataforma"))
            //StateManager.instance.currentState = StateManager.KnifeState.STUCK;
    }
    private void OnTriggerEnter(Collider other)
    {
        //print(other.tag);
    }
}
