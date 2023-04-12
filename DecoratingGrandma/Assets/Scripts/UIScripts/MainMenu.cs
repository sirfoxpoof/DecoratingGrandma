using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MainMenu : MonoBehaviour
{
    public void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void NewGameButton()
    {
        PlayerPrefs.SetInt("StartPosition", 0);
        SceneManager.LoadScene("GameScene");
        print("start new game");

    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quits game");
    }
    
    public void ContinueButton()
    {
        PlayerPrefs.SetInt("StartPosition", 1);
        SceneManager.LoadScene("GameScene");
        print("continue game");


    }
        




}

