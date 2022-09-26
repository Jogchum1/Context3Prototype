using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponentInParent<IDamageablePlayer>() != null)
        {
            other.gameObject.GetComponentInParent<IDamageablePlayer>().TakeDamage();
        }
    }
}
