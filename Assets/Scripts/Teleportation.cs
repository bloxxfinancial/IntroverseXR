using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;


    public void MoveTo()
    {
        thePlayer.transform.position = teleportTarget.transform.position;

    }
}
