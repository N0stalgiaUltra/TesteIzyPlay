using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDistanceCheck : MonoBehaviour
{
    [SerializeField] private StateManager stateManager;
    [SerializeField] private float distance;

    public void CheckCubeDistance(List<ObjectSlice> cubeList)
    {
        //if (cubeList.Count.Equals(0))
        //    return;
        //else
        //{
        //    for (int i = 0; i < cubeList.Count; i++)
        //    {
        //        if (Vector3.Distance(this.gameObject.transform.position, cubeList[i].gameObject.transform.position) <= distance)
        //        {
        //            stateManager.knifeTouch.SliceObject(cubeList[i]);
        //        }
        //        else
        //        {

        //        }
        //            //stateManager.ObjectSliceRef = null;

        //    }
        //}

    }
}
