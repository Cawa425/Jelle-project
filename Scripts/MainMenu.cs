using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject MainMenuUI;

    public void LoadGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameScene");
        Debug.Log("Loading game...");
    }

    public void QuitGame()
    {
        Time.timeScale = 1f;
        Debug.Log("Quitting game...");
        Application.Quit();
    }

    public void LoadSettings()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Settings");
        Debug.Log("Loading settings...");
    }
}
