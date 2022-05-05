using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupUi : MonoBehaviour
{
    public GameObject uiMessage;
    public GameObject lightGroup;


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiMessage.SetActive(true);
            lightGroup.SetActive(true);            

        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiMessage.SetActive(false);
            lightGroup.SetActive(false);
        }
    }
}
