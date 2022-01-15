using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public Animator animator;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;

    float velocityX = 0.0f;
    float velocityZ = 0.0f;
    public float acceleration = 2.0f;
    public float deceleration = 2.0f;

    public void FixedUpdate()
    {

        bool forwardPressed = Input.GetKey("w");
        bool leftPressed = Input.GetKey("a");
        bool rightPressed = Input.GetKey("d");
        bool runPressed = Input.GetKey("left shift");

        /* Combat */
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.SetTrigger("Slash");
            Debug.Log("Left Click was pressed. ");
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("Dance");
            Debug.Log("F key was pressed.");
        }

        /* Walking */
        if (forwardPressed && velocityX <= 0.5 && !runPressed)
        {
            velocityX += 0.025f;
        }
        else if (forwardPressed && velocityX > 0.5 && !runPressed)
        {
            velocityX -= 0.05f;
        }
        if (!forwardPressed && velocityX > 0)
        {
            velocityX -= 0.05f;
        }

        /* Running */
        if (runPressed && forwardPressed && velocityX < 1)
        {
            velocityX += 0.035f;
        }
        
        /* Walking left */
        if (leftPressed && velocityZ > -1)
        {
            velocityZ -= 0.05f;
        }
        if (!leftPressed && velocityZ < 0 )
        {
            velocityZ += 0.05f;
        }

        /* Walking right */
        if (rightPressed && velocityZ < 1)
        {
            velocityZ += 0.05f;
        }
        if (!rightPressed && velocityZ > 0)
        {
            velocityZ -= 0.05f;
        }

        animator.SetFloat("Velocity X", velocityX);
        animator.SetFloat("Velocity Z", velocityZ);

        /* Jumping */

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded)
        {
            animator.SetBool("Jumping", false);
        }
        
        if(!isGrounded)
        {
            animator.SetBool("Jumping", true);
        }
    }
}
