using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed, startSpeed, horizontalMovement, verticalMovement;
    public Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        startSpeed = 10;
        moveSpeed = startSpeed;
    }

    // Update is called once per frame
    void Update()
    {

        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");

        movement.x = horizontalMovement;
        movement.z = verticalMovement;

        transform.Translate(movement * Time.deltaTime);
    }
}
