using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WagonMove : MonoBehaviour, IDamageable
{
    private GameObject City;

    [SerializeField] private int Speed;
    


    // Start is called before the first frame update
    void Start()
    {
        City = GameObject.FindGameObjectWithTag("Flag");
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, City.transform.position, Speed * Time.deltaTime);

    }
    public void TakeDamage()
    {
        Destroy(gameObject);   
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Water")
        {
            Destroy(gameObject);
        }
    }
}
