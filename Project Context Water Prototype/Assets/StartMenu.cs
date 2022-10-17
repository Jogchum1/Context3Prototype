using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject PauzeMenu;

    private void Start()
    {
        PauzeMenu.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauzeMenu.SetActive(true);
            Time.timeScale = 0f;
        }    
    }

    public void Continue()
    {
        PauzeMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void StartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;

    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene("Start");

    }
}
