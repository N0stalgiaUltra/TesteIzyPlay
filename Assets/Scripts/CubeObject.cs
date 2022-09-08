using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeObject : MonoBehaviour
{
    [SerializeField] private MeshRenderer mainObject;
    [SerializeField] private GameObject leftHalf;
    [SerializeField] private GameObject rightHalf;
    [SerializeField] private ScoreData scoreData;

    public void SetupCube()
    {
        this.mainObject.enabled = true;
        this.gameObject.layer = LayerMask.NameToLayer("Default");
        this.leftHalf.SetActive(false);
        this.rightHalf.SetActive(false);

    }

    public void Slice()
    {
        mainObject.enabled = false;
        mainObject.gameObject.layer = LayerMask.NameToLayer("Inactive");
        leftHalf.SetActive(true);
        rightHalf.SetActive(true);
    }

    public int CubeScore { get => scoreData.score; }
}
