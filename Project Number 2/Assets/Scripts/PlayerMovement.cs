using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    public Animator animator; 

    Vector2 movement; 
    Vector2 movementDelta;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


        if(movement.sqrMagnitude != 0)
        {
            movementDelta = movement;
        }
        


        //Idle values
        animator.SetFloat("IdleHorizontal", movementDelta.x);
        animator.SetFloat("IdleVertical", movementDelta.y);

        //MovementValues
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    private void Move()
    {
        rb.velocity = new Vector2(movement.x, movement.y);
    }
}

