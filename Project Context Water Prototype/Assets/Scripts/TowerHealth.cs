using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerHealth : MonoBehaviour, IDamageable
{
    public int TowerHitpoints = 3;
    public CityHealth cityHealth;

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
