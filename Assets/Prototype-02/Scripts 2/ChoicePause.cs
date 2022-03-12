using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoicePause : MonoBehaviour
{
    public GameObject buttonPanel;
    public bool choice;
    void Start()
    {
        choice = false;
        buttonPanel.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            Pause();
    }

    public void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        choice = !choice;
        buttonPanel.SetActive(choice);
        Time.timeScale = choice ? 0 : 1;
    }
}
