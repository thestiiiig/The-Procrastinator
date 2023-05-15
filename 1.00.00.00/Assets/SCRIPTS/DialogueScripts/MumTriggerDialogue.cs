using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MumTriggerDialogue : MonoBehaviour
{
    public Dialogue dialogue; //creating the new dialogue

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue); //Triggers the dialogue using the manager
    }
}
