using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneLook : MonoBehaviour
{
    public Transform target;
    public int MaxDist = 30;
    public int MinDist = 5;

    public void Update()
    {
        if (Vector3.Distance(transform.position, target.position) <= MaxDist)//not MinDist
        {
            transform.LookAt(target);
        }

    }
}
