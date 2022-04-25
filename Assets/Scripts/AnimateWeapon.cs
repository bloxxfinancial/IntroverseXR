using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimateWeapon : MonoBehaviour
{
    public GameObject weaponObject;

    private Animator animWeapon;
    public Button butWeapon1;
    public Button butWeapon2;
    public Button butWeapon3;
    public Button butWeapon4;
    public Button butWeapon5;


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
        butWeapon1.enabled = false;
        butWeapon2.enabled = false;
        butWeapon3.enabled = false;
        butWeapon4.enabled = false; 
        butWeapon5.enabled = false;
        yield return new WaitForSeconds(4);
        animWeapon.SetBool("spin", false);
        butWeapon1.enabled = true;
        butWeapon2.enabled = true;
        butWeapon3.enabled = true;
        butWeapon4.enabled = true;
        butWeapon5.enabled = true;

    }

}
