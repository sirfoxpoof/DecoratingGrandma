using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManeger : MonoBehaviour
{
    public TMP_Text textUI;
    public UISO textManeger;
    public int uiSlide;
    public BaseQuest baseQuest;
    // Start is called before the first frame update
    void Start()
    {
        textUI.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        UITextManeger();
    }

    public void UITextManeger()
    {
        textUI.text = textManeger.uiDialouge[uiSlide];

        if (baseQuest.questStatusInComplete == true)
        {
            StartCoroutine(baseQuest.UIDelay());
        }

        if (baseQuest.questStatusComplete == true)
        {
            uiSlide = 1;
        }
    }
}
