using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ThreatManager : MonoBehaviour
{
    EquationGenerator EG;

    public Button threatbutton1;
    public Button threatbutton2;
    public Button threatbutton3;
    public Button threatbutton4;
    public Button threatbutton5;
    public Button threatbutton6;
    public Button threatbutton7;
    public Button threatbutton8;
    public Button threatbutton9;
    public Button threatbutton10;

    void Start()
    {
        EG = EquationGenerator.instance;
       
        threatbutton1.interactable = false;
        threatbutton2.interactable = false;
        threatbutton3.interactable = false;
        threatbutton4.interactable = false;
        threatbutton5.interactable = false;
        threatbutton6.interactable = false;
        threatbutton7.interactable = false;
        threatbutton8.interactable = false;
        threatbutton9.interactable = false;
        threatbutton10.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(EG.Dscore);

     //  if (Input.GetKeyDown(KeyCode.Z))
      //  {
      //      EG.Dscore += 1;
     //  }
     
        if (EG.Dscore == 1)
        {
            threatbutton1.interactable = true;
        }
        if (EG.Dscore == 2)
        {
          
            threatbutton2.interactable = true;
        }
        if (EG.Dscore == 3)
        {
            threatbutton3.interactable = true;
        }
        if (EG.Dscore == 4)
        {
            threatbutton4.interactable = true;
        }
        if (EG.Dscore == 5)
        {
            threatbutton5.interactable = true;
        }
        if (EG.Dscore == 6)
        {
            threatbutton6.interactable = true;
        }
        if (EG.Dscore == 7)
        {
            threatbutton7.interactable = true;
        }
        if (EG.Dscore == 8)
        {
            threatbutton8.interactable = true;
        }
        if (EG.Dscore == 9)
        {
            threatbutton9.interactable = true;
        }
        if (EG.Dscore == 10)
        {
            threatbutton10.interactable = true;
        }
    
    }
}
