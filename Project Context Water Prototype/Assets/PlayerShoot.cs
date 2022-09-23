using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        
    }

    public void Shoot(GameObject cannonball, GameObject Player)
    {
        GameObject CannonRight;
        GameObject CannonLeft;



        if (Input.GetKeyDown(KeyCode.Space))
        {
            CannonRight = cannonball;
            CannonLeft = cannonball;


            CannonRight = GameObject.Instantiate(cannonball, Player.transform.localPosition, Quaternion.Euler(Player.transform.forward)) as GameObject;
            CannonRight.GetComponent<Rigidbody>().AddForce(Player.transform.right * 20, ForceMode.Impulse);

            CannonLeft = GameObject.Instantiate(cannonball, Player.transform.localPosition, Quaternion.Euler(Player.transform.forward)) as GameObject;
            CannonLeft.GetComponent<Rigidbody>().AddForce(Player.transform.right * -20, ForceMode.Impulse);


        }
    }
}
