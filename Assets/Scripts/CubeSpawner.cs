using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private CubeObject sliceCube;
    [SerializeField] private List<CubeObject> cubeList = new List<CubeObject>();
    [SerializeField] private List<Transform> spawnList = new List<Transform>(6);
    [SerializeField] private int quantity;
    void Awake()
    {
        if (quantity.Equals(0))
            return;
        else
        {
            for (int i = 0; i < quantity; i++)
            {
                cubeList.Add(sliceCube);
                cubeList[i].SetupCube();
            }

        }

    }

    private void Start()
    {
        if (quantity.Equals(0) || spawnList.Count.Equals(0))
            return;
        else
        {
            for (int i = 0; i < quantity; i++)
            {
                Instantiate(cubeList[i].gameObject, spawnList[i].transform);
            }

        }
    }


}
