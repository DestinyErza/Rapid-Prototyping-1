using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoicePause : MonoBehaviour
{
    public GameObject buttonPanel;
    public GameObject buttonPanel2;
    public GameObject buttonPanel3;
    public GameObject speechPanel;
    public bool choice;
    void Start()
    {
        choice = false;
        Time.timeScale = 1;
        Cursor.visible = false;
        buttonPanel.SetActive(false);
        buttonPanel.SetActive(false);
        buttonPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            Pause();
        else Cursor.visible = false;

        if (Input.GetKeyDown(KeyCode.Alpha2))
            Pause2();

        if (Input.GetKeyDown(KeyCode.Alpha3))
            Pause3();

        if (Input.GetKeyDown(KeyCode.Alpha4))
            Pause();

        if (Input.GetKeyDown(KeyCode.Alpha5))
            Pause();
    }

    public void Pause()
    {
        speechPanel.SetActive(false);
        Cursor.visible = true;
        choice = !choice;
        buttonPanel.SetActive(choice);
        Time.timeScale = choice ? 0 : 1;
    }

    public void Pause2()
    {
        speechPanel.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        choice = !choice;
        buttonPanel2.SetActive(choice);
        Time.timeScale = choice ? 0 : 1;
    }


    public void Pause3()
    {
        speechPanel.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        choice = !choice;
        buttonPanel3.SetActive(choice);
        Time.timeScale = choice ? 0 : 1;
    }
}
