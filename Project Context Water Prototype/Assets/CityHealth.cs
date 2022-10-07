using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CityHealth : MonoBehaviour, IDamageable
{
    public Slider CityHealthSlider;
    public int CityHp;
    public int MaxCityHp;


    // Start is called before the first frame update
    void Start()
    {
        CityHp = MaxCityHp;
        CityHealthSlider.maxValue = CityHp;
        CityHealthSlider.value = CityHp;
    }

    // Update is called once per frame
    void Update()
    {
        CityHealthSlider.value = CityHp;
        if(CityHp > MaxCityHp)
        {
            CityHp = MaxCityHp;
        }
    }

    public void TakeDamage()
    {
        CityHp--;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Koets")
        {
            CityHp += 3;
            Destroy(other.gameObject);
        }
    }
}
