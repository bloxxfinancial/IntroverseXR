using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jodyAnimControl : MonoBehaviour
{
    public GameObject avatarCharacter;
    private Animator animAvatar;

    void Start()
    {
        animAvatar = avatarCharacter.GetComponent<Animator>();
        animAvatar.enabled = false;

        StartCoroutine(AnimateControl());
    }

    IEnumerator AnimateControl()
    {
        yield return new WaitForSeconds(10);
        animAvatar.enabled = true;
        yield return new WaitForSeconds(13.16f);
        animAvatar.enabled = false;
        yield return new WaitForSeconds(1);
        StartCoroutine(AnimateControl());

    }

}
