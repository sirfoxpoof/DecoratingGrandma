using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SettingsMenuHandler : MonoBehaviour
{
    public SaveLoad saveLoadScript;
    public Canvas mainMenu;
    public void Start()
    {
        mainMenu.gameObject.SetActive(false);
        Time.timeScale = 1;

    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            PauseGame();
            Cursor.lockState = CursorLockMode.None;
            
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            saveLoadScript.LoadData();
        }
         
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("TestMenuScene");
    }

    public void ToggleFullScreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
        Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
        Debug.Log("fullscreen");

    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        mainMenu.gameObject.SetActive(true);
        Debug.Log("PausedGame");
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        mainMenu.gameObject.SetActive(false);
        Debug.Log("resumed game");
    }


    public void SaveButtionFunction()
    {
        saveLoadScript.SaveData();
        Debug.Log("saveDataViaSettings");

    }
}
