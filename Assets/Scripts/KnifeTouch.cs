using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeTouch : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;

    private void Update()
    {
        if (Input.anyKeyDown)
            Impulse();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
       
    }

    void Impulse()
    {
        
        rb.AddForce(new Vector3(0, 2, 1) * speed, ForceMode.Impulse);
        rb.AddTorque(Vector3.right * speed, ForceMode.Impulse);
    }
}
