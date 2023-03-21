using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed, sprintSpeed, startSpeed, horizontalMovement, verticalMovement, stamina;
    public bool sprint;
    public Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        startSpeed = 10;
        moveSpeed = startSpeed;
        sprintSpeed = 5;

        sprint = false;
        stamina = 200;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");

        movement.x = horizontalMovement;
        movement.z = verticalMovement;

        transform.Translate(movement * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            sprint = true;

            if (sprint == true)
            {
                moveSpeed = sprintSpeed;
            }
        }

        else
        {
            moveSpeed = startSpeed;
        }


    }
}