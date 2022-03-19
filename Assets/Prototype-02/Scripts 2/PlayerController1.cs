using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
using UnityStandardAssets.Characters.FirstPerson;

public enum PlayerState { Exploring, Interacting}
public class PlayerController1 : Singleton<PlayerController1>
{
    private Rigidbody playerRb;
    private SpawnManager SM;

    public TMP_Text InitiateDialogue;
    public GameObject InitiatePanel;
    public GameObject WinPanel;
    public bool correctanswer;
    public PlayerState playerState;

    public int score;
    public TMP_Text scoreText;
    public TMP_Text winText;


    RigidbodyFirstPersonController fpc;
   


    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        InitiateDialogue.text = "";
        WinPanel.SetActive(false);
        Time.timeScale = 1;
        InitiatePanel.SetActive(false);
        fpc = GetComponent<RigidbodyFirstPersonController>();
       
    }
   

    void Update()
    {
        scoreText.text = "score: " + score;

        if (playerState == PlayerState.Interacting)
        {
            fpc.enabled = false;
        }
        else
        {
            fpc.enabled = true;
        }

        ///choices
        ///
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            AddScore();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            MinusScore();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Win();
        }
    

        if (Input.GetKeyDown(KeyCode.Q))
        {
            InitiatePanel.SetActive(false);
            
        }

     
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("character"))
        {
            InitiatePanel.SetActive(true);
            InitiateDialogue.text = "Press Q to interact";
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("character"))
        {
            InitiatePanel.SetActive(false);
            InitiateDialogue.text = "";
        }
    }

    public void AddScore()
    {
        score += 1;
        // ButtonPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void MinusScore()
    {
        score -= 1;
        Time.timeScale = 1;
    }

    public void Continue()
    {
        Time.timeScale = 1;
    }

    public void Win()
    {

        WinPanel.SetActive(true);

        if (score >= 4)
        {
            winText.text = "congratulations player, you know the truth.You are dead. But do not worry, your joining the stars.<3";
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else 
        {
            winText.text = "You failed, you made the wrong choices and left your chance to know the truth behind...";
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
