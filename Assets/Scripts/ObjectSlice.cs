using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSlice : MonoBehaviour
{
    [SerializeField] private MeshRenderer mainObject;
    [SerializeField] private BoxCollider mainCollider;

    [SerializeField] private GameObject leftHalf;
    [SerializeField] private GameObject rightHalf;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButton(0))
        //    SliceObject();
    }

    public void SliceObject()
    {
        mainObject.enabled = false;
        this.gameObject.layer = LayerMask.NameToLayer("Inactive");
        leftHalf.SetActive(true);
        rightHalf.SetActive(true);  
    }
}
