using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour
{

    public Text pickUpText;
    public string TriggerName;
    public Animator animator;
    public bool pickUpAllowed;

    // Start is called before the first frame update
    void Start()
    {
        pickUpText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
            PickUp();
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name.Equals("isTrigger"))
        {
            pickUpText.gameObject.SetActive(true);
            pickUpAllowed = true;
        }
    }

    public void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name.Equals("isTrigger"))
        {
            pickUpText.gameObject.SetActive(false);
            pickUpAllowed = false;
        }
    }
    public void PickUp()
    {
        Destroy(gameObject);
        animator.SetTrigger(TriggerName);
    }
}
