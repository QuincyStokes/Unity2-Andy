using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMenuManager : MonoBehaviour
{
    public KeyCode pauseGameKey = KeyCode.Escape;
    public KeyCode pauseGameKey1 = KeyCode.P;
    public KeyCode resetGameKey = KeyCode.R;
    public KeyCode quitGameKey = KeyCode.Q;
    public GameObject pauseMenu;
    
    private static bool isPaused = false;

    public static bool GameIsPaused()
    {
        return isPaused;
    }


    void Start()
    {
        isPaused = false;
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(pauseGameKey) || Input.GetKeyDown(pauseGameKey1))
        {
            if(isPaused)
            {
                UnpauseGame();
            }
            else
            {
                PauseGame();
            }
        }

        if(Input.GetKeyDown(resetGameKey) && isPaused)
        {
            ResetGame();
        }


        if(Input.GetKeyDown(quitGameKey) && isPaused)
        {
            QuitGame();
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
    }

    public void UnpauseGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }

    public void ResetGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
