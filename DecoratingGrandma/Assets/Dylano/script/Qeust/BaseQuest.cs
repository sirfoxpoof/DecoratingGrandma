using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TMPro;
using UnityEngine;

public class BaseQuest : MonoBehaviour
{
    public GameObject player, buttonPannel;
    public TMP_Text questText;
    public int slide, maxSlide;
    public bool questStatus, questStatusInComplete, questStatusComplete, questAccepted, questDiclined;
    public UIManeger uiManeger;
    public QeustSOScript questConversation;

    // Start is called before the first frame update
    void Start()
    {
        questDiclined = false;
        maxSlide = 3;
        questAccepted= false;
        questStatusInComplete= false;
        //crossAirCanvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void QeustDialouge()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < 5f)
        {
            if (questStatus == false)
            {
                questText.enabled = true;

                if (Input.GetKeyUp(KeyCode.F) && slide <= 0)
                {
                    slide = 1;
                }
            }

            if (Input.GetMouseButtonDown(0) && slide >= 1 && slide < maxSlide)
            {
                slide += 1;
            }

            if (slide == maxSlide)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                //crossAirCanvas.SetActive(false);
                buttonPannel.SetActive(true);
            }

            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                //crossAirCanvas.SetActive(true);
                buttonPannel.SetActive(false);
            }
        }

        else
        {
            questText.enabled = false;
        }

        if (questText.enabled && questStatus == false)
        {
            questText.text = questConversation.dialouge[slide];
        }
    }

    public void CancelButton()
    {
        buttonPannel.SetActive(false);
        questDiclined = true;
        slide = 5;
        StartCoroutine(declineDelay());
    }

    public void AcceptButton()
    {
        buttonPannel.SetActive(false);
        questAccepted= true;
        StartCoroutine(AcceptDelay());
    }

    public IEnumerator AcceptDelay()
    {
        yield return new WaitForSeconds(4);
        questAccepted = false;
        slide = 0;
    }

    public IEnumerator declineDelay()
    {
        yield return new WaitForSeconds(4);
        questDiclined = false;
        slide = 0;
    }

    public IEnumerator Delay()
    {
        yield return new WaitForSeconds(4);
        slide = 0;
    }

    public IEnumerator UIDelay()
    {
        yield return new WaitForSeconds(4);
        uiManeger.uiSlide = 0;
        uiManeger.textUI.enabled = true;
    }

}