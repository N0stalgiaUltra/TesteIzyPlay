using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeTouch : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private ScoreManager scoreManager;

    public void Impulse(Rigidbody rb)
    {
        rb.AddForce(new Vector3(0, 2, 1) * speed, ForceMode.Impulse);
        rb.AddTorque(Vector3.right * speed, ForceMode.Impulse);
    }

    public void SliceObject(CubeObject obj)
    {
        obj.Slice();
        scoreManager.AddScore(obj.CubeScore);
    }
}
