using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

public class Movement : MonoBehaviour
{
    public float hor, ver, moveSpeed;
    public Vector3 moveDirection, jump;
    public Rigidbody rb;
    public RaycastHit hit;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; 
        moveSpeed = 10;
                    
    }

    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        moveDirection.z = ver;
        moveDirection.x = hor;

        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        if(Physics.Raycast(transform.position, -transform.up, out hit, 1))
        {
            if(hit.collider.tag == "Ground")
            {
                if (Input.GetButtonDown("Jump"))
                {
                    rb.velocity += jump; 
                }

            }
                
        }

    }

    

  


}
