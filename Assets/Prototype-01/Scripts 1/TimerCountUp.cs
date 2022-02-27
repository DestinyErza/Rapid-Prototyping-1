using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerCountUp : MonoBehaviour
{
    public TMP_Text timerText;
    private float time;
    
    void Update()
    {
        UpdateTimerUI();
    }
    //call this on update
    public void UpdateTimerUI()
    {
        //set timer UI
        time += Time.deltaTime;
        timerText.text = "Time:" + (int)time;
       
    }
}
