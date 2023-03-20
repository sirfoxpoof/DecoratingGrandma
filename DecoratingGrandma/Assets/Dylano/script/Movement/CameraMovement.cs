using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float verticalCamMovement, horizontalCamMovement;
    public Transform fppCamera;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalCamMovement = Input.GetAxis("Mouse X");
        verticalCamMovement = Input.GetAxis("Mouse Y");

        transform.Rotate(-0, horizontalCamMovement, 0);
        fppCamera.Rotate(-verticalCamMovement, 0, 0);
    }
}
