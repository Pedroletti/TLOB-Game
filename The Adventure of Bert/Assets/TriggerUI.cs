using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TriggerUI : MonoBehaviour
{

    public TextMeshProUGUI pickUpText;
    public Animator animator1;
    public string TriggerName1;
    public Animator animator2;
    public string TriggerName2;

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
        if (collision.gameObject.name.Equals("3rd Person Player"))
        {
            pickUpText.gameObject.SetActive(true);
            pickUpAllowed = true;
        }
    }

    public void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name.Equals("3rd Person Player"))
        {
            pickUpText.gameObject.SetActive(false);
            pickUpAllowed = false;
        }
    }
    public void PickUp()
    {
        animator1.SetTrigger(TriggerName1);
        animator2.SetTrigger(TriggerName2);
    }
    
}
