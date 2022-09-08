using System;
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
        SetupCube();
    }

    private void SetupCube()
    {
        this.mainObject.enabled = true;
        this.gameObject.layer = LayerMask.NameToLayer("Default");
        this.leftHalf.SetActive(false);
        this.rightHalf.SetActive(false);

    }

    public void SliceObject()
    {
        this.mainObject.enabled = false;
        this.gameObject.layer = LayerMask.NameToLayer("Inactive");
        this.leftHalf.SetActive(true);
        this.rightHalf.SetActive(true);  
    }
}
