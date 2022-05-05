using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitWorld : MonoBehaviour
{
    public GameObject exitText;
    public GameObject thankText;
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(ExitProtocol());       
            
        }

        IEnumerator ExitProtocol()
        {
            exitText.SetActive(false);
            thankText.SetActive(true);
            yield return new WaitForSeconds(1);
            Application.Quit();

        }
    }
}
