using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    DialogueSystem dialogueSystem;
    // Start is called before the first frame update
    void Start()
    {
        dialogueSystem = DialogueSystem.instance;
    }

    public string[] dialogue = new string[]
    {
        "PLACEHOLDER :Marnie",
        "PLACEHOLDER",
        "PLACEHOLDER",
        "PLACEHOLDER: PLAYER",
        "press 1 to initiate options"
    };

    int index = 0;

    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            PlayerController1.instance.playerState = PlayerState.Interacting;
            dialogueSystem.TogglePanel(true);

            if (!dialogueSystem.isSpeaking || dialogueSystem.isWaitingForInput)
            {
                if (index >= dialogue.Length)
                {
                    PlayerController1.instance.playerState = PlayerState.Exploring;
                    return;
                }
                Say(dialogue[index]);
                index++;
            }
        }

    }

    private void OnTriggerExit(Collider other)
    {
        dialogueSystem.TogglePanel(false);
        index = 0;
    }

    void Say(string s)
    {
        string[] parts = s.Split(':');
        string speech = parts[0];
        string speaker = (parts.Length >= 2) ? parts[1] : "";
        dialogueSystem.say(speech, speaker);
    }
}
