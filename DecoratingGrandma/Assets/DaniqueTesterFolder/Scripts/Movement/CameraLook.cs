using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    public float mouseX, mouseY, sensitivity;
    public Vector3 lookDirectionBody, lookDirectionCamera;
    public Transform bodyTransform, cameraTransform;


    void Start()
    {
        sensitivity = 15f;
    }

    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * sensitivity;
        mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        lookDirectionBody.y = mouseX;
        lookDirectionCamera.x = -mouseY;
        
        bodyTransform.Rotate(lookDirectionBody);
        cameraTransform.Rotate(lookDirectionCamera);
    }
}
