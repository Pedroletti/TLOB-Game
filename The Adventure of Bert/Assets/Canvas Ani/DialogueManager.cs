using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;

    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        Animator animator = GetComponent<Animator>();
        CharacterController cc = GetComponent<CharacterController>();
        MouseLook ml = GetComponent<MouseLook>();
    }

    public void StartDialogue (Dialogue dialogue)
    {

        // Character Lock
        Cursor.lockState = CursorLockMode.None;
        GameObject.Find("3rd Person Player").GetComponent<Rigidbody>().isKinematic = true;
        GameObject.Find("Character").GetComponent<Animator>().SetBool("Chat", true);
        GameObject.Find("3rd Person Player").GetComponent<CharacterController>().enabled = false;
        GameObject.Find("Main Camera").GetComponent<MouseLook>().enabled = false;

        GameObject.Find("Canvas").GetComponent<Animator>().SetBool("DialogueBox", true);

        nameText.text = dialogue.name;
    

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        Debug.Log("End of conversation.");
        GameObject.Find("Canvas").GetComponent<Animator>().SetBool("DialogueBox", false);
        
        // Character lock
        Cursor.lockState = CursorLockMode.Locked;
        GameObject.Find("3rd Person Player").GetComponent<Rigidbody>().isKinematic = false;
        GameObject.Find("Character").GetComponent<Animator>().SetBool("Chat", false);
        GameObject.Find("3rd Person Player").GetComponent<CharacterController>().enabled = true;
        GameObject.Find("Main Camera").GetComponent<MouseLook>().enabled = true;
    }

}
