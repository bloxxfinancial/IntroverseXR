using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehickeController : MonoBehaviour
{
    private Animator animVehicle;
    public GameObject vehicleObject;
    private AudioSource hoverSound;

    void Start()
    {
        animVehicle = vehicleObject.GetComponent<Animator>();
        hoverSound = vehicleObject.GetComponent<AudioSource>();
        animVehicle.enabled = false;

        StartCoroutine(StartVehicle());
    }

    IEnumerator StartVehicle()
    {
        yield return new WaitForSeconds(20);
        animVehicle.enabled = true;
        hoverSound.Play();
        yield return new WaitForSeconds(5);
        hoverSound.Stop();
        yield return new WaitForSeconds(34.3f);
        hoverSound.Play();
        yield return new WaitForSeconds(14.7f);
        animVehicle.enabled = false;
        hoverSound.Stop();
        yield return new WaitForSeconds(10);
        StartCoroutine(StartVehicle());



    }
}
