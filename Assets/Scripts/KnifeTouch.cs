using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeTouch : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.anyKeyDown)
            Impulse();
    }

    void Impulse()
    {
        rb.AddForce(Vector3.up * speed, ForceMode.Impulse);
    }
}
