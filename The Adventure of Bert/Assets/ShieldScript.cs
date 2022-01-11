using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldScript : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            animator.SetTrigger("Defend");
        }
        else
        {
            animator.SetTrigger("stopDefend");
        }
    }
}
