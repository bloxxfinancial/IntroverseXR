using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactivateFashion : MonoBehaviour
{
    public GameObject fashionCollider;

    public GameObject triggerWeapon;
    public GameObject triggerPets;

    public GameObject lightGroup;


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerPets.SetActive(false);
            triggerWeapon.SetActive(false);
            lightGroup.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            fashionCollider.SetActive(true);
            triggerPets.SetActive(true);
            triggerWeapon.SetActive(true);
            lightGroup.SetActive(false);
        }
    }
}
