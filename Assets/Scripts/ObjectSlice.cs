using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSlice : MonoBehaviour
{
    [SerializeField] private MeshRenderer mainObject;
    [SerializeField] private GameObject leftHalf;
    [SerializeField] private GameObject rightHalf;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
            SliceObject();
    }

    void SliceObject()
    {
        mainObject.enabled = false;
        leftHalf.SetActive(true);
        rightHalf.SetActive(true);  
    }
}
