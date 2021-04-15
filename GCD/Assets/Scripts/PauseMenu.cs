using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{


    // Update is called once per frame
    public static bool GameIsPaused = false;

    public GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        if (GameIsPaused)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameIsPaused = !GameIsPaused;
        }
    }
    public void Resume()
    {
        GameIsPaused = !GameIsPaused;
    }
    public void Menu()
    {

        Debug.Log("Loading...");
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);

    }
    public void LoadMenu()
    {

        Debug.Log("Loading...");
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);

    }

    public void Exit()
    {
        Debug.Log("Exitting...");
        Application.Quit();
    }

}
