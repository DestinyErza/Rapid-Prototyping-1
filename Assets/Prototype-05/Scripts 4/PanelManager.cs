using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public GameObject hidingPanel;
    public GameObject wolfPanel;
    public bool paused;
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        paused = false;
        hidingPanel.SetActive(false);
        wolfPanel.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            Wolf();
    }

    public void Wolf()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        paused = !paused;
        hidingPanel.SetActive(paused);
        Time.timeScale = paused ? 0 : 1;
    }
    public void WolfC()
    {
        paused = !paused;
        
        Time.timeScale = paused ? 0 : 1;
        wolfPanel.SetActive(false);
    }

    public void Hiding()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        paused = !paused;
        wolfPanel.SetActive(paused);
        Time.timeScale = paused ? 0 : 1;
    }
    public void HidingC()
    {
        paused = !paused;
        hidingPanel.SetActive(false);
        Time.timeScale = paused ? 0 : 1;
    }
}
