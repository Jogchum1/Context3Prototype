using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeFlag : MonoBehaviour, IInteractable
{

    public Material PrinseVlag;


    public void Interact()
    {
        gameObject.GetComponent<Renderer>().material = PrinseVlag;
    }
    
}
