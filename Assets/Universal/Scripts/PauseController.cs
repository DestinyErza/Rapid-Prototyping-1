using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    public GameObject pausePanel;
    public bool paused;
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        paused = false;
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Pause();
    }

     public void Pause()
    {
        paused = !paused;
        pausePanel.SetActive(paused);
        Time.timeScale = paused ? 0 : 1;
    }
}
