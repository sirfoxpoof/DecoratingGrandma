using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public PlayerData playerData;

    public void SaveData()
    {
        PlayerPrefs.SetInt("playerHealth", playerData.healthAmount);

        playerData.SavePosition();
        PlayerPrefs.SetFloat("playerPositionX", playerData.positionX);
        PlayerPrefs.SetFloat("playerPositionY", playerData.positionY);
        PlayerPrefs.SetFloat("playerPositionZ", playerData.positionZ);
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

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SaveData();
            Debug.Log("Save doet het");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            LoadData();
            Debug.Log("Load doet het");
        }
    }
}
