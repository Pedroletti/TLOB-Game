using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    public string TriggerName;
    public Animator animator;

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name.Equals("3rd Person Player"))
        {
            animator.SetTrigger("Load");
        }
    }
}
