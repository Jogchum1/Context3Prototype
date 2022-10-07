using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerHealth : MonoBehaviour, IDamageable
{
    public int TowerHitpoints = 3;
    public CityHealth cityHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage()
    {
        TowerHitpoints--;
        cityHealth.TakeDamage();
        if(TowerHitpoints <= 0)
        {
            Destroy(gameObject);
        }
    }


}
