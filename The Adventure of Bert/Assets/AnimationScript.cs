using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public Animator animator;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.SetTrigger("Slash");
            Debug.Log("Left Click was pressed. ");
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("BattleCry");
            Debug.Log("F key was pressed.");
        }
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetTrigger("Walk");
        }
        if (!Input.GetKey(KeyCode.W))
        {
            animator.SetTrigger("Idle");
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("Running", false);
            animator.SetTrigger("Run");
        }
        if (!Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("Running", true); 
        }
    }
}
