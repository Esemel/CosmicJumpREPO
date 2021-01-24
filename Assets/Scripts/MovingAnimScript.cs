using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingAnimScript : MonoBehaviour
{
    public float moveInput;
    public Animator animator;
    private bool isMoving = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        animator.SetBool("IsMoving", isMoving);
        if (moveInput < 0f)
        {
            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.y = 180;
            transform.rotation = Quaternion.Euler(rotationVector);
            isMoving = true;
        }

        if (moveInput > 0f)
        {
            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.y = 0;
            transform.rotation = Quaternion.Euler(rotationVector);
            isMoving = true;
        }

        if(moveInput == 0)
        {
            isMoving = false;
        }
    }
}
