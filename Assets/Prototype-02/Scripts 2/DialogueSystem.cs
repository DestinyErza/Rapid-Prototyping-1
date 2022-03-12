using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueSystem : MonoBehaviour
{
    public static DialogueSystem instance;
    public ELEMENTS elements;
   

    private void Awake()
    {
        instance = this;
    }

    public void Start()
    {
        isWaitingForInput = false;
        speechPanel.SetActive(false);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            speechPanel.SetActive(false);

        }
    }
    

    /// <summary>
    /// shows speech in dialogue box
    /// </summary>
    public void say(string speech, string name = "")
    {
        StopSpeaking();
        speaking = StartCoroutine(Speaking(speech, name ));
    }

    public void StopSpeaking()
    {
        if (isSpeaking)
        {
            StopCoroutine(speaking);
        }
        speaking = null;
    }

    [HideInInspector] public bool isWaitingForInput = false;
    public bool isSpeaking { get { return speaking != null; } }
    Coroutine speaking = null;
    IEnumerator Speaking(string targetSpeech, string name = "")
    {
        speechPanel.SetActive(true);
        speech.text = "";
        speakerName.text = DetermineSpeaker(name);

        while(speech.text != targetSpeech)
        {
            speech.text += targetSpeech[speech.text.Length];
            yield return new WaitForEndOfFrame();
        }
        //text finished
        isWaitingForInput = true;
        while (isWaitingForInput)
            yield return new WaitForEndOfFrame();
        StopSpeaking();
    }

    string DetermineSpeaker(string s)
    {
        string retVal = speakerName.text;
        if (s != speakerName.text && s != "")
            retVal = (s.ToLower().Contains("narrator")) ? "" : s;
               return retVal;
    }

    /// <summary>
    /// contains all dilogue related elements from ui
    /// </summary>
    [System.Serializable]
    public class ELEMENTS
    {
        public GameObject speechPanel;
        public TMP_Text speakerName;
        public TMP_Text speech;
    }
    public GameObject speechPanel { get { return elements.speechPanel; } }
    public TMP_Text speakerName { get { return elements.speakerName; } }
    public TMP_Text speech { get { return elements.speech; } }
}
