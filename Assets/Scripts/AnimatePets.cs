using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimatePets : MonoBehaviour
{
    public GameObject petObject;

    public Button buttonPet1;
    public Button buttonPet2;
    public Button buttonPet3;
    public Button buttonPet4;
    public Button buttonPet5;
    public Button buttonPet6;
    public Button buttonPet7;
    public Button buttonPet8;


    public void SelectPet()
    {
        StartCoroutine(ShowProtocol());

    }

    IEnumerator ShowProtocol()
    {
        petObject.SetActive(true);
        buttonPet1.enabled = false;
        buttonPet2.enabled = false;
        buttonPet3.enabled = false;
        buttonPet4.enabled = false;
        buttonPet5.enabled = false;
        buttonPet6.enabled = false;
        buttonPet7.enabled = false;
        buttonPet8.enabled = false;
        yield return new WaitForSeconds(6);
        buttonPet1.enabled = true;
        buttonPet2.enabled = true;
        buttonPet3.enabled = true;
        buttonPet4.enabled = true;
        buttonPet5.enabled = true;
        buttonPet6.enabled = true;
        buttonPet7.enabled = true;
        buttonPet8.enabled = true;
        petObject.SetActive(false);

    }

}

