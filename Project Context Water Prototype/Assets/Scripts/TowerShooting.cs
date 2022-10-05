using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShooting : MonoBehaviour
{
    public GameObject player;
    public GameObject arrow;
    public bool CityCaptured = false;

    private GameObject arrowShoot;

    public int timer = 200;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);
        if (CityCaptured == false)
        {
            if (distance <= 10)
            {
                Shoot(distance);
            }
        }
    }


    void Shoot(float distance)
    {
        timer--;

        if(timer <= 0)
        {

            Vector3 direction = (player.transform.position - transform.position).normalized;

            arrowShoot = Instantiate(arrow, new Vector3(transform.position.x, transform.position.y + 2, transform.position.z), Quaternion.identity);
            arrowShoot.GetComponent<Rigidbody>().AddForce(direction * 500);
            timer = 200;
            Destroy(arrowShoot, 3);
        }
    }
}
