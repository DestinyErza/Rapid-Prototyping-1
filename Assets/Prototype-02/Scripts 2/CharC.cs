using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharC : MonoBehaviour
{
    DialogueSystem dialogue;
    // Start is called before the first frame update
    void Start()
    {
        dialogue = DialogueSystem.instance;
    }

    public string[] s = new string[]
    {
        "leave me alone. :????",
        "leave. "
    };

    int index = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
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
