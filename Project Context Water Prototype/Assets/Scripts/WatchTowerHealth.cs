using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchTowerHealth : MonoBehaviour, IDamageable
{
    public int TowerHitpoints = 3;

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
        if (TowerHitpoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
