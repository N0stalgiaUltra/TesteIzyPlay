using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private ObjectSlice sliceCube;
    [SerializeField] private List<ObjectSlice> cubeList = new List<ObjectSlice>();
    [SerializeField] private List<Transform> spawnList = new List<Transform>(6);
    [SerializeField] private int quantity;

    [SerializeField] private CubeDistanceCheck cubeDistance;
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
        if (quantity.Equals(0))
            return;
        else
        {
            for (int i = 0; i < quantity; i++)
            {
                Instantiate(cubeList[i].gameObject, spawnList[i].transform);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        //cubeDistance.CheckCubeDistance(cubeList);
    }


}
