using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Qeust1 : MonoBehaviour
{
    public GameObject player, buttonPannel;
    public GameObject[] stick;
    public TMP_Text textMeshPro, stickUITMP;
    public int slide, maxSlide, sticksPickedUp, visebleStick, maxVisebleStick;
    public bool qeustStatus, qeustStatusIncomplete, qeustStatusComplete;
    public QeustSOScript questConversation;

    // Start is called before the first frame update
    void Start()
    {
        buttonPannel.SetActive(false);
        textMeshPro.enabled = false;
        qeustStatus = false;
        qeustStatusIncomplete = false;
        qeustStatusComplete = false;
        stick[visebleStick].SetActive(false);
        maxVisebleStick = 5;
        visebleStick = maxVisebleStick;
        stickUITMP.enabled= false;
        stickUITMP.text = questConversation.dialouge[slide];

        for (visebleStick = 0; visebleStick < stick.Length; visebleStick++)
        {
            stick[visebleStick].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        QeustDialouge();
        QeustStatusIncomplete();
        QeustStatusComplete();
    }

    // holds dialouge for the quest
    public void QeustDialouge()
    {

        if (Vector3.Distance(player.transform.position, transform.position) < 5f )
        {
            if (qeustStatus == false)
            {
                textMeshPro.enabled = true;

                if (Input.GetKeyUp(KeyCode.E) && slide <= 0)
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
            }

            else
            {
                Cursor.lockState= CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }

        else
        {
            textMeshPro.enabled = false;
        }

        if (textMeshPro.enabled && qeustStatus == false)
        {
            textMeshPro.text = questConversation.dialouge[slide];
        }

        if (slide == maxSlide)
        {
            buttonPannel.SetActive(true);
        }

        else
        {
            buttonPannel.SetActive(false);
        }
    }

    public void QeustStatusIncomplete()
    {
        if (qeustStatusIncomplete == true)
        {
            for (visebleStick = 0; visebleStick < stick.Length; visebleStick++)
            {
                stick[visebleStick].SetActive(true);
            }

            if (Input.GetKeyUp(KeyCode.E))
            {
                slide = 6;
                StartCoroutine(Delay());
            }
        }
    }

    public void QeustStatusComplete()
    {
        if (qeustStatusComplete == true)
        {

            if (Input.GetKeyUp(KeyCode.E))
            {
                slide = 7;

                if (Input.GetMouseButtonDown(0) && slide == 7)
                {
                    slide += 1;
                }
            }
        }
    }

    public void Quest()
    {
        if (qeustStatusIncomplete == true)
        {

            if (Input.GetKeyDown(KeyCode.E))
            {
                sticksPickedUp += 1;
                Destroy(stick[sticksPickedUp]);
                Debug.Log("e has been pressed");
            }

            if (sticksPickedUp == 5)
            {
                qeustStatusComplete= true;
                qeustStatusIncomplete= false;
            }
        }
    }

    public void CancelButton()
    {
        slide = 5;
        StartCoroutine(declineDelay());
    }

    public void AcceptButton()
    {
        buttonPannel.SetActive(false);
        slide = 4;
        StartCoroutine(AcceptDelay());
    }

    public IEnumerator AcceptDelay()
    {
        yield return new WaitForSeconds(4);
        slide = 0;
        qeustStatusIncomplete = true;
    }

    public IEnumerator declineDelay()
    {
        yield return new WaitForSeconds(4);
        slide = 0;
    }

    public IEnumerator Delay()
    {
        yield return new WaitForSeconds(4);
        slide = 0;
    }

}
