using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoicePause : MonoBehaviour
{
    public GameObject buttonPanel;
    public GameObject speechPanel;
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

        if (Input.GetKeyDown(KeyCode.Alpha2))
            Pause();

        if (Input.GetKeyDown(KeyCode.Alpha3))
            Pause();

        if (Input.GetKeyDown(KeyCode.Alpha4))
            Pause();

        if (Input.GetKeyDown(KeyCode.Alpha5))
            Pause();
    }

    public void Pause()
    {
        speechPanel.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        choice = !choice;
        buttonPanel.SetActive(choice);
        Time.timeScale = choice ? 0 : 1;
    }
}
