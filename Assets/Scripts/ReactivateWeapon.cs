using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReactivateWeapon : MonoBehaviour
{
    public Button butWeapon1;
    public Button butWeapon2;
    public Button butWeapon3;
    public Button butWeapon4;
    public Button butWeapon5;

    public GameObject triggerFashion;
    public GameObject triggerPets;
    public GameObject weaponGroup;


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerFashion.SetActive(false);
            triggerPets.SetActive(false);
            weaponGroup.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            butWeapon1.enabled = true;
            butWeapon2.enabled = true;
            butWeapon3.enabled = true;
            butWeapon4.enabled = true;
            butWeapon5.enabled = true;
            triggerFashion.SetActive(true);
            triggerPets.SetActive(true);
            weaponGroup.SetActive(false);
        }
            
    }
}
