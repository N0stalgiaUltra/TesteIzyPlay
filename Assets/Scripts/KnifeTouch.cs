using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeTouch : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Update()
    {
        
    }


    public void Impulse(Rigidbody rb)
    {
        rb.AddForce(new Vector3(0, 2, 1) * speed, ForceMode.Impulse);
        rb.AddTorque(Vector3.right * speed, ForceMode.Impulse);
    }
}
