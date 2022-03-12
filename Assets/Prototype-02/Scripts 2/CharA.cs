using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharA : MonoBehaviour
{
    DialogueSystem dialogue;
    // Start is called before the first frame update
    void Start()
    {
        dialogue = DialogueSystem.instance;
    }

    public string[] s = new string[]
    {
        "if i.... :Maia",
        "test b",
        "test c",
        "uh oh: test name bbb",
        "press 1 to initiate options"
    };

    int index = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
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

