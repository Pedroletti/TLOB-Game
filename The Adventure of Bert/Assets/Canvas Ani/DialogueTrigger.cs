using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public TextMeshProUGUI pickUpText;
    private bool chat;

    void Start()
    {
        pickUpText.gameObject.SetActive(false);
    }

    void Update()
    {
        if (chat && Input.GetKeyDown(KeyCode.E))
        {
            TriggerDialogue();
        }
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name.Equals("3rd Person Player"))
        {
            pickUpText.gameObject.SetActive(true);
            chat = true;
        }
    }
    public void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name.Equals("3rd Person Player"))
        {
            pickUpText.gameObject.SetActive(false);
            chat = false;
        }
    }
}
