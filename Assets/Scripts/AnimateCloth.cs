using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimateCloth : MonoBehaviour
{
    public GameObject fashionObject;
    public GameObject fashionProduct;
   
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
        fashionProduct.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        animFashion.SetBool("spin", true);
        buttonGroup.SetActive(false);
        yield return new WaitForSeconds(2.5f);
        animFashion.SetBool("spin", false);
        fashionProduct.SetActive(false);
        buttonGroup.SetActive(true);
        

    }
}
