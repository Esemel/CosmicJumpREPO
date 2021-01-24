using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Jumping : MonoBehaviour
{
    public float walkSpeed = 6.0f;
    public float moveInput;
    public bool isGrounded;
    private Rigidbody2D rb;
    public bool canJump = true;
    public float oxygen = 100.0f;
    public float jumpValue = 0.0f;
    public PhysicsMaterial2D bounceMat, normalMat;
    public Animator animator;
    float direction = 0f;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        
            moveInput = Input.GetAxisRaw("Horizontal");
            
       

        rb.velocity = new Vector2(moveInput * walkSpeed, rb.velocity.y);
        animator.SetFloat("JumpValue", jumpValue);
        if (jumpValue > 0)
         {
             rb.sharedMaterial = bounceMat;

         }
         
        
        if (Input.GetKey("space") && isGrounded )
        {
           
            if (jumpValue <= 10.0f)
                
                jumpValue += 0.25f;
            animator.SetFloat("JumpValue",jumpValue);
        }
        if (Input.GetKeyDown("space") && isGrounded)
        {
            rb.velocity = new Vector2(0.0f, rb.velocity.y);
        }
        if (jumpValue >= 10f && isGrounded)
        {
            float tempx = moveInput * walkSpeed;
            float tempy = jumpValue;
            rb.velocity = new Vector2(tempx, tempy);
            ResetJump();

        }
        if (Input.GetKeyUp("space"))
        {
            if (isGrounded)
            {
                rb.velocity = new Vector2(moveInput * walkSpeed, jumpValue);
                jumpValue = 0f;
            }
            
        }
    
    }
    void ResetJump()
    {
        canJump = false;
        jumpValue = 0;
        isGrounded = false;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawCube(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 0.5f), new Vector2(0.9f, 0.2f));
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Platform"))
        {
            Debug.Log("Player zderzył się z kostką.");
            isGrounded = true;
          
        }

    }
    
}
