using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemies : MonoBehaviour
{

    public string notes;

    public TMP_Text DisplayText;


    //displays note text in inventory
    public void SetText(string text)
    {
        DisplayText.text = notes;
    }

}
