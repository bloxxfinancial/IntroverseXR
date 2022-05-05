using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomeMessage : MonoBehaviour
{
    public GameObject uiMessage;
    public GameObject triggerPoint;


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiMessage.SetActive(true);
            

        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiMessage.SetActive(false);
            triggerPoint.SetActive(false);
        }
    }
}
