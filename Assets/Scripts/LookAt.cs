using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField] private Transform lookTarget = null;

    private void Update()
    {
        Vector3 lookPos = new Vector3(lookTarget.position.x, transform.position.y, lookTarget.position.z);

        transform.LookAt(lookPos);
    }
}
