using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmoVehicle : MonoBehaviour
{
    private Animator armoVehicle;
    public GameObject armoObject;
    private AudioSource hoverSound;

    void Start()
    {
        armoVehicle = armoObject.GetComponent<Animator>();
        armoVehicle.enabled = false;
        hoverSound = armoObject.GetComponent<AudioSource>();

        StartCoroutine(StartVehicle());
    }

    IEnumerator StartVehicle()
    {
        yield return new WaitForSeconds(20);
        armoVehicle.enabled = true;
        hoverSound.Play();
        yield return new WaitForSeconds(22.4f);
        hoverSound.Stop();
        yield return new WaitForSeconds(60);
        hoverSound.Play();
        yield return new WaitForSeconds(17);
        armoVehicle.enabled = false;
        hoverSound.Stop();
        yield return new WaitForSeconds(10);
        StartCoroutine(StartVehicle());
    }
}
