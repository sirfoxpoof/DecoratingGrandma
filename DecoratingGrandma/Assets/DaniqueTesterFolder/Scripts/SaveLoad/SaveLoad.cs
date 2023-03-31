using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SaveLoad : MonoBehaviour
{
    public PlayerData playerData;
    
    
    public void SaveData()    {
        PlayerPrefs.SetInt("playerHealth", playerData.healthAmount);

        playerData.SavePosition();
        PlayerPrefs.SetFloat("playerPositionX", playerData.positionX);
        PlayerPrefs.SetFloat("playerPositionY", playerData.positionY + 1f);
        PlayerPrefs.SetFloat("playerPositionZ", playerData.positionZ);
        PlayerPrefs.SetString("SaveDataExists", "True");
        PlayerPrefs.Save();
    }
    public void LoadData()
    {
        playerData.healthAmount = PlayerPrefs.GetInt("playerHealth");
        playerData.positionX = PlayerPrefs.GetFloat("playerPositionX");
        playerData.positionY = PlayerPrefs.GetFloat("playerPositionY");
        playerData.positionZ = PlayerPrefs.GetFloat("playerPositionZ");
        playerData.LoadPosition();
        


    }

    
}
