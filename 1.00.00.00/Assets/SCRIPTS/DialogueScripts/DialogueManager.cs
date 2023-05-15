using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueManager : MonoBehaviour
{
    public Text nameText;     //these two variables are for updating the UI according to the script
    public Text dialogueText;

    public Animator animator;

    private Queue<string> sentences;  //The variable, similar to an array, holding the entire list of sentences

    void Start()
    {
        sentences = new Queue<string>(); //Instance of the Sentences Queue
    }

    public void StartDialogue (Dialogue dialogue)
    {
        //Debug.Log("Starting Conversation with " + dialogue.name);   //checking whether the dialogue button works

        animator.SetBool("IsOpen", true); //start open animation

        nameText.text = dialogue.name; //update the name UI

        sentences.Clear();   //remove any previously spoken sentences to avoid clash

        foreach (string sentence in dialogue.sentences)  //Refer to each sentence
        {
            sentences.Enqueue(sentence);  //Place the sentence in the queue
        }

        DisplayNextSentence();  //Display next sentence, function defined below
    }

    public void DisplayNextSentence ()  
    {
        if (sentences.Count == 0)  //If the sentences left are none
        {
            EndDialogue();               //End the dialogue entirely, Function defined below
            return;
        }

        string sentence = sentences.Dequeue(); //If sentences are still left
        //Debug.Log(sentence);
        StopAllCoroutines(); //stop previous animations
        StartCoroutine(TypeSentence(sentence)); //begin next animation

    }

    IEnumerator TypeSentence (string sentence)  //type one letter at a time
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
        //Debug.Log("End of conversation!");   //Send a debug message to know that the sentences were all spoken
        animator.SetBool("IsOpen", false); //close the dialogue window
    }
    
}
