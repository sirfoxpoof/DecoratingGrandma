using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public int healthAmount;
    public GameObject player;
    public float positionX, positionY, positionZ;

    private void Update()
    {

    }

    public void SavePosition ()
    {
        positionX = player.transform.position.x;
        positionY = player.transform.position.y;
        positionZ = player.transform.position.z;
    }

    public void LoadPosition ()
    {
        player.transform.position = new Vector3(positionX, positionY, positionZ);
    }
}

  
