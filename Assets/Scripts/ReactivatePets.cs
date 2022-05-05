using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ReactivatePets : MonoBehaviour
{
    public Button butPet1;
    public Button butPet2;
    public Button butPet3;
    public Button butPet4;
    public Button butPet5;
    public Button butPet6;
    public Button butPet7;
    public Button butPet8;

    public GameObject triggerWeapon;
    public GameObject triggerFashion;


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerFashion.SetActive(false);
            triggerWeapon.SetActive(false);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            butPet1.enabled = true;
            butPet2.enabled = true;
            butPet3.enabled = true;
            butPet4.enabled = true;
            butPet5.enabled = true;
            butPet6.enabled = true;
            butPet7.enabled = true;
            butPet8.enabled = true;
            triggerFashion.SetActive(true);
            triggerWeapon.SetActive(true);

        }

    }
}
