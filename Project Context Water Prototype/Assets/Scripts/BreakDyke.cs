using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakDyke : MonoBehaviour, IInteractable
{
    public GameObject dyke;
    public GameObject water;

    public void Interact()
    {
        water.SetActive(true);
        Destroy(dyke);
        Destroy(gameObject);
    }
}
