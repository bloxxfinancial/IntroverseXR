using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimateWeapon : MonoBehaviour
{
    [SerializeField] public GameObject weaponObject;

    private Animator animWeapon;
    public Button buttonWeapon1;
    public Button buttonWeapon2;
    public Button buttonWeapon3;
    public Button buttonWeapon4;
    public Button buttonWeapon5;


    void Start()
    {
        animWeapon = weaponObject.GetComponent<Animator>();
    }

    public void SelectWeapon()
    {
        StartCoroutine(SpinProtocol());
        
    }

    IEnumerator SpinProtocol()
    {
        animWeapon.SetBool("spin", true);
        buttonWeapon1.enabled = false;
        buttonWeapon2.enabled = false;
        buttonWeapon3.enabled = false;
        buttonWeapon4.enabled = false;
        buttonWeapon5.enabled = false;
        yield return new WaitForSeconds(6);
        buttonWeapon1.enabled = true;
        buttonWeapon2.enabled = true;
        buttonWeapon3.enabled = true;
        buttonWeapon4.enabled = true;
        buttonWeapon5.enabled = true;
        animWeapon.SetBool("spin", false);

    }

}
