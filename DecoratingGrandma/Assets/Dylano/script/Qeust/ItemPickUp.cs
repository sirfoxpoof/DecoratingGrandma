using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public BaseQuest baseQuest;
    public Quest1 quest1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(baseQuest.player.transform.position, transform.position) < 3f)
        {
            if ((Input.GetKeyUp(KeyCode.E)) && baseQuest.questStatusInComplete == true)
            {
                quest1.stick.SetActive(false);
                baseQuest.questStatusComplete = true;
            }
        }
    }
}
