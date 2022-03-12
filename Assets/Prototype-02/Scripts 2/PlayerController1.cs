using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class PlayerController1 : Singleton<PlayerController>
{
    private Rigidbody playerRb;
    private SpawnManager SM;

    public TMP_Text InitiateDialogue;
    public GameObject InitiatePanel;
   




    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        InitiateDialogue.text = "";
        Time.timeScale = 1;
        InitiatePanel.SetActive(false);
    }
   

    void Update()
    {
      
    }

   
    /// <summary>
    /// promptss player interaction
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("CharA"))
        {
            InitiatePanel.SetActive(true);
            InitiateDialogue.text = "press z!";
         
        }

        if (other.CompareTag("CharB"))
        {
            InitiatePanel.SetActive(true);
            InitiateDialogue.text = "press X!";

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("CharA"))
        {
            InitiatePanel.SetActive(false);
            InitiateDialogue.text = "";
           
        }

        if (other.CompareTag("CharB"))
        {
            InitiatePanel.SetActive(false);
            InitiateDialogue.text = "";

        }
    }











}
