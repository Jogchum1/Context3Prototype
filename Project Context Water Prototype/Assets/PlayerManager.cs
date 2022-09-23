using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject CanonnBall;
    public GameObject Player;

    public int Healthpoints;

    PlayerHealth playerHealth = new PlayerHealth();
    PlayerShoot playerShoot = new PlayerShoot();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerHealth.hp = Healthpoints;

        playerShoot.Shoot(CanonnBall, Player);
    }

    
}
