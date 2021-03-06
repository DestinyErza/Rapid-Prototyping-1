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
    public Camera cam1;
    public Camera cam2;
    public TMP_Text camText;
    public GameObject camimage;

   

    RigidbodyFirstPersonController fpc;
   


    void Start()
    {
        InitiatePanel.SetActive(false);
        camimage.SetActive(false);
        playerRb = GetComponent<Rigidbody>();
        InitiateDialogue.text = "";
        WinPanel.SetActive(false);
        Time.timeScale = 1;
      
        fpc = GetComponent<RigidbodyFirstPersonController>();
        cam1.enabled = true;
        cam2.enabled = false;
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
            CameraToggle();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            MinusScore();
            CameraToggle();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Win();
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {

            cam1.enabled = !cam1.enabled;
            cam2.enabled = !cam2.enabled;
            camimage.SetActive(false) ;
            camText.text = "";
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

    public void CameraToggle()
    {
        cam1.enabled = !cam1.enabled;
        cam2.enabled = !cam2.enabled;
        camText.text = "press 6 to retun to player:)";
        camimage.SetActive(true);
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
