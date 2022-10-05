using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BreakDyke : MonoBehaviour, IDamageable
{
    public GameObject dyke;
    public GameObject water;

    public int Health = 5;
    
    public void Interact()
    {
        
    }

    public void Start()
    {
        water.SetActive(false);

        
    }

    public void TakeDamage()
    {
        Health--;

        if(Health <= 0)
        {
            water.SetActive(true);
            Destroy(dyke);
            Destroy(gameObject);
        }
    }
}
