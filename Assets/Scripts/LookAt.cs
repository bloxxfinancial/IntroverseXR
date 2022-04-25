using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform target;
    public int MaxDist = 5;
    //public int MinDist = 1;

    public void Update()
    {
        if (Vector3.Distance(transform.position, target.position) <= MaxDist)//not MinDist
        {
            transform.LookAt(target);
        }

    }
}
