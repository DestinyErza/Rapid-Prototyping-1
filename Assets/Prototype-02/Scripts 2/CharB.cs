using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharB : MonoBehaviour
{
    DialogueSystem dialogue;
    // Start is called before the first frame update
    void Start()
    {
        dialogue = DialogueSystem.instance;
    }

    public string[] s = new string[]
    {
        "PLACEHOLDER :Altea",
        "PLACEHOLDER",
        "PLACEHOLDER",
        "PLACEHOLDER: PLAYER",
        "press 2 to initiate options"
    };

    int index = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (!dialogue.isSpeaking || dialogue.isWaitingForInput)
            {
                if (index >= s.Length)
                {
                    return;
                }
                Say(s[index]);
                index++;
            }
        }


    }

    void Say(string s)
    {
        string[] parts = s.Split(':');
        string speech = parts[0];
        string speaker = (parts.Length >= 2) ? parts[1] : "";
        dialogue.say(speech, speaker);
    }
}
