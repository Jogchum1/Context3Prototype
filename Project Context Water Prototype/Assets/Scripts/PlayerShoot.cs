using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot
{
    private bool ReadyToShoot;
    private int ShootCooldownTimer = 30;

    // Start is called before the first frame update
    void Start()
    {
        ReadyToShoot = true;
    }

    // Update is called once per frame
    public void Update()
    {
        
    }

    public void Shoot(GameObject cannonball, GameObject Player, ParticleSystem canonSmoke)
    {
        GameObject CannonRight;
        GameObject CannonLeft;

        if(ReadyToShoot == false)
        {
            ShootCooldownTimer--;
            if(ShootCooldownTimer <= 0)
            {
                ReadyToShoot = true;
                ShootCooldownTimer = 100;
            }
        }


        if (Input.GetKeyDown(KeyCode.Space) && ReadyToShoot == true)
        {
            CannonRight = cannonball;
            CannonLeft = cannonball;


            CannonRight = GameObject.Instantiate(cannonball, Player.transform.localPosition, Quaternion.Euler(Player.transform.forward)) as GameObject;
            CannonRight.GetComponent<Rigidbody>().AddForce(Player.transform.right * 20, ForceMode.Impulse);

            CannonLeft = GameObject.Instantiate(cannonball, Player.transform.localPosition, Quaternion.Euler(Player.transform.forward)) as GameObject;
            CannonLeft.GetComponent<Rigidbody>().AddForce(Player.transform.right * -20, ForceMode.Impulse);
            canonSmoke.Play();
            ReadyToShoot = false;


        }
    }
}
