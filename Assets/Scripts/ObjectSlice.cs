using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSlice : MonoBehaviour
{
    [SerializeField] private MeshRenderer mainObject;
    [SerializeField] private GameObject leftHalf;
    [SerializeField] private GameObject rightHalf;

    public void SetupCube()
    {
        this.mainObject.enabled = true;
        this.gameObject.layer = LayerMask.NameToLayer("Default");
        this.leftHalf.SetActive(false);
        this.rightHalf.SetActive(false);

    }

    public void Slice()
    {
        print("slicing");
        mainObject.enabled = false;
        mainObject.gameObject.layer = LayerMask.NameToLayer("Inactive");
        leftHalf.SetActive(true);
        rightHalf.SetActive(true);
    }
}
