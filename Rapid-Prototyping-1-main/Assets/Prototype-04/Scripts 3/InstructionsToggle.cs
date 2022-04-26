using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsToggle : MonoBehaviour
{
    public GameObject pausePanel;
    public bool paused;
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        paused = false;
      
        Time.timeScale = 1;
    }

   
    

    public void Pause()
    {
        paused = !paused;
        pausePanel.SetActive(paused);
        Time.timeScale = paused ? 0 : 1;
    }
}
