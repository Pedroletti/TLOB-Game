using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceScript : MonoBehaviour
{
    public Animator animator;

    public void OnTriggerEnter(Collider collision)
    {

        /* Dance */ 
        if (collision.gameObject.name.Equals("3rd Person Player"))
        {
            animator.SetBool("Dance", true);
            Debug.Log("Dancing!");
        }
    }

    public void OnTriggerExit(Collider collision)
    {
        /* Dance */ 
        if (collision.gameObject.name.Equals("3rd Person Player"))
        {
            animator.SetBool("Dance", false);
        }
    }
}
