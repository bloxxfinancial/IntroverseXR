using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactivateWelcomeTri : MonoBehaviour
{
    public GameObject triggerPoint;


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerPoint.SetActive(true);


        }
    }

   
}

