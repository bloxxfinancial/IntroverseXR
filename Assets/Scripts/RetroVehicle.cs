using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetroVehicle : MonoBehaviour
{
    private Animator retroVehicle;
    public GameObject retroObject;
    private AudioSource hoverSound;

    void Start()
    {
        retroVehicle = retroObject.GetComponent<Animator>();
        retroVehicle.enabled = false;
        hoverSound = retroObject.GetComponent<AudioSource>();

        StartCoroutine(StartVehicle());
    }

    IEnumerator StartVehicle()
    {
        yield return new WaitForSeconds(15);
        retroVehicle.enabled = true;
        hoverSound.Play();
        yield return new WaitForSeconds(36);
        hoverSound.Stop();
        retroVehicle.enabled = false;
        yield return new WaitForSeconds(5);
        StartCoroutine(StartVehicle());
    }
}
