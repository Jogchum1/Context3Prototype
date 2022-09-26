using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDamageablePlayer
{
    public int hp;

    public PlayerHealth()
    {

    }

    public void TakeDamage()
    {
        hp--;
        Debug.Log("Auw");
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

   
}
