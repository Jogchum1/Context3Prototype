using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerManager : MonoBehaviour
{
    public GameObject CanonnBall;
    public GameObject Player;

    public Slider HealthSlider;

    public int Healthpoints;

    PlayerHealth playerHealth;
    PlayerShoot playerShoot = new PlayerShoot();

    

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GetComponent<PlayerHealth>();

        playerHealth.hp = Healthpoints;
        HealthSlider.maxValue = playerHealth.hp;
        HealthSlider.value = playerHealth.hp;


    }

    // Update is called once per frame
    void Update()
    {
        HealthSlider.value = playerHealth.hp;

        if(playerHealth.hp <= 0)
        {
            Debug.Log("You died!");
            Scene scene = SceneManager.GetActiveScene(); 
            SceneManager.LoadScene(scene.name);

        }

        playerShoot.Shoot(CanonnBall, Player);
    }

    
}
