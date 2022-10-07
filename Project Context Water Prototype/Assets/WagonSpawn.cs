using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WagonSpawn : MonoBehaviour
{
    public GameObject StartPoint1;
    public GameObject StartPoint2;
    public GameObject StartPoint3;

    public GameObject KoetsPrefab;

    [SerializeField] private int SpawnCooldown;
    private List<GameObject> KoetsList = new List<GameObject>();
    private GameObject Koets;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnCooldown--;

        if (SpawnCooldown <= 0)
        {
            KoetsList.Add(Koets);
            KoetsList.Add(Koets);
            KoetsList.Add(Koets);


            Koets = Instantiate(KoetsPrefab, StartPoint1.transform.position, Quaternion.identity);
            Koets = Instantiate(KoetsPrefab, StartPoint2.transform.position, Quaternion.identity);
            Koets = Instantiate(KoetsPrefab, StartPoint3.transform.position, Quaternion.identity);


            SpawnCooldown = 200;
        }

        


    }
}
