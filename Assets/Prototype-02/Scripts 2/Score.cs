using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : GameBehaviour
{
    public int score;
    public TMP_Text scoreText;

    public GameObject ButtonPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "score: " + score;

    }

    public void AddScore()
    {
        score += 1;
        ButtonPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void MinusScore()
    {
        score -= 1;
        ButtonPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void CharCbranchPOS()
    {
        score += 1;
        ButtonPanel.SetActive(false);
        Time.timeScale = 1;
        _PC1.correctanswer = true;
    }

    public void CharCbranchNEG()
    {
        score -= 1;
        ButtonPanel.SetActive(false);
        Time.timeScale = 1;
        _PC1.correctanswer = false;
    }
}
