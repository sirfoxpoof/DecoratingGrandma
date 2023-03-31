using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MainMenu : MonoBehaviour
{
    public GameObject panel;
    
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");

    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quits game");
    }
    
    public void ContinueButton()
    {
        /*if(PlayerPrefs.GetString("SaveDataExists") == "True")
        {
            playerData.healthAmount = PlayerPrefs.GetInt("playerHealth");
            playerData.positionX = PlayerPrefs.GetFloat("playerPositionX");
            playerData.positionY = PlayerPrefs.GetFloat("playerPositionY");
            playerData.positionZ = PlayerPrefs.GetFloat("playerPositionZ");
            playerData.LoadPosition();
        }
              

        else
        {
            panel.SetActive(true);

        }*/
        
    }
        




}

