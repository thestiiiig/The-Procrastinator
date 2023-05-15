using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float moveSpeed = 5f; //speed

    public Rigidbody2D rb; //rigidbody

    public Animator animator; //animator

    Vector2 movement; //movement

    public bool movementEnabled = true; //movement is allowed

    // Update is called once per frame
    void Update()
    {

        if (movementEnabled) //The player can move using these below controls as long as movement is enabled
		{
            movement.x = Input.GetAxis("Horizontal"); //get horizontal keys
            movement.y = Input.GetAxis("Vertical");  //get vertical key input

            animator.SetFloat("Horizontal", movement.x);  //set the sideways animation to horizontal  keys 
            animator.SetFloat("Vertical", movement.y);   //set the vertical animation to vertical keys
            animator.SetFloat("Speed", movement.sqrMagnitude); //link the speed to the animation
        }

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime); //Movement Position
    }
}
