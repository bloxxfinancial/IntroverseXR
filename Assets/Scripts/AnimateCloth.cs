using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimateCloth : MonoBehaviour
{
    public GameObject fashionObject;
   
    private Animator animFashion;
    public GameObject buttonGroup;


    void Start()
    {
        animFashion = fashionObject.GetComponent<Animator>();
    }

    public void SelectCloth()
    {
        StartCoroutine(SpinProtocol());

    }

    IEnumerator SpinProtocol()
    {
        animFashion.SetBool("spin", true);
        buttonGroup.SetActive(false);
        yield return new WaitForSeconds(4);
        animFashion.SetBool("spin", false);
        buttonGroup.SetActive(true);
        

    }
}
