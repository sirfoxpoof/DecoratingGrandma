using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public int healthAmount;
    public GameObject player;
    public float positionX, positionY, positionZ;
    public SaveLoad saveLoad;

    public void Awake()
    {
        if(PlayerPrefs.GetInt("StartPosition") == 0)
        {
            NewGamePosition();
        }

        if(PlayerPrefs.GetInt("StartPosition") == 1)
        {
            saveLoad.LoadData();
            LoadPosition();
        }
    }

    private void Update()
    {
        if (healthAmount <= 0)
        {
            saveLoad.LoadData();
            print("dood");
        }
    }

    public void SavePosition ()
    {
        positionX = player.transform.position.x;
        positionY = player.transform.position.y;
        positionZ = player.transform.position.z;
    }

    public void NewGamePosition()
    {
        positionX = 1;
        positionY = 2;
        positionZ = 1;

        player.transform.position = new Vector3(
            positionX,
            positionY,
            positionZ
        );
    }

    public void LoadPosition ()
    {
        player.transform.position = new Vector3(positionX, positionY, positionZ);
    }

    
}

  
