using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public AudioSource backMusic;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            backMusic.Play();
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            backMusic.Stop();
        }
    }
}
