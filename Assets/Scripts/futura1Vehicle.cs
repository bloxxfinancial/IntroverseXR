using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class futura1Vehicle : MonoBehaviour
{
    private Animator animFutural1;
    public GameObject futura1Object;
    private AudioSource hoverSound;

    void Start()
    {
        animFutural1 = futura1Object.GetComponent<Animator>();
        hoverSound = futura1Object.GetComponent<AudioSource>();
        animFutural1.enabled = false;

        StartCoroutine(StartVehicle());
    }

    IEnumerator StartVehicle()
    {
        yield return new WaitForSeconds(7);
        animFutural1.enabled = true;
        hoverSound.Play();
        yield return new WaitForSeconds(10);
        hoverSound.Stop();
        yield return new WaitForSeconds(66.4f);
        hoverSound.Play();
        yield return new WaitForSeconds(28.6f);
        animFutural1.enabled = false;
        hoverSound.Stop();
        yield return new WaitForSeconds(10);
        StartCoroutine(StartVehicle());



    }
}
