using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Quest1 : MonoBehaviour
{
    public BaseQuest baseQuest;
    public GameObject player, stick;
    public bool lastDialouge;

    // Start is called before the first frame update
    void Start()
    {
        stick.SetActive(false);
        lastDialouge = false;
    }

    // Update is called once per frame
    void Update()
    {
        Quest();
        baseQuest.QeustDialouge();
        Accepted();
    }

    public void Quest()
    {
        if ((Input.GetKeyUp(KeyCode.F)) && baseQuest.questStatusInComplete == true)
        {
            baseQuest.slide = 6;
            StartCoroutine(baseQuest.Delay());
        }

        if ((Input.GetKeyUp(KeyCode.F)) && baseQuest.questStatusComplete == true)
        {
            baseQuest.slide = 7;

            if (Input.GetMouseButtonDown(0) && baseQuest.questStatusComplete ==true)
            {
                Debug.Log("works");
                baseQuest.slide = 8;
                lastDialouge = true;
                StartCoroutine(baseQuest.Delay());
            }
        }

        if (baseQuest.questStatusComplete == true)
        {
            baseQuest.questStatusInComplete = false;
        }

        if ((Input.GetKeyUp(KeyCode.F)) && lastDialouge == true)
        {
            baseQuest.slide = 9;
            StartCoroutine(baseQuest.Delay());
        }
    }

    public void Accepted()
    {
        if (baseQuest.questAccepted == true)
        {
            baseQuest.slide = 4;
            baseQuest.buttonPannel.SetActive(false);
            baseQuest.questStatusInComplete = true;
            stick.SetActive(true);
        }
    }

    public void Denied()
    {
        if (baseQuest.questAccepted == true)
        {
            baseQuest.slide = 5;
            baseQuest.buttonPannel.SetActive(false);
        }
    }
}
