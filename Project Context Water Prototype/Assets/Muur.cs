using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muur : MonoBehaviour, IDamageable
{
    public int WallHitPoints = 3;
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
        WallHitPoints--;
        cityHealth.TakeDamage();
        if (WallHitPoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
