using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EquationGenerator : MonoBehaviour
{
    public enum Difficulty { EASY, MEDIUM, HARD }

    public Difficulty difficulty;

    public int numberOne;
    public int numberTwo;
    public int correctAnswer;

    public TMP_Text numberone;
    public TMP_Text numbertwo;
    public TMP_Text wronganswer;
    public TMP_Text answer;
    public TMP_Text symbol;

    public TMP_Text[] answerPoints;

    public List<int> dummyAnswers;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            GenerateMultiplication();
            symbol.text = "X";
            UpdateInterface();

        }



        if (Input.GetKeyDown(KeyCode.A))
        {
            GenerateAddition();
            symbol.text = "+";
            UpdateInterface();
        }


        if (Input.GetKeyDown(KeyCode.D))
        {
            GenerateDivision();
            symbol.text = "÷";
            UpdateInterface();
        }


        //  if (Input.GetKeyDown(KeyCode.R))
        //      GenerateRandomEquation();
        //  UpdateInterface();
    }

    void GenerateRandomEquation()
    {
        int rnd = Random.Range(1, 100);
        if (rnd <= 35)
            GenerateAddition();
        else if (rnd <= 60)
            GenerateSubtraction();
        else if (rnd <= 90)
            GenerateMultiplication();
        else
            GenerateDivision();
    }

    void GenerateMultiplication()
    {
        numberOne = GetRandomNumbers();
        numberTwo = GetRandomNumbers();
        correctAnswer = numberOne * numberTwo;

        Debug.Log(numberOne + " x " + numberTwo + " = " + correctAnswer);

        GenerateDummyAnswers();
    }

    void GenerateAddition()
    {
        numberOne = GetRandomNumbers();
        numberTwo = GetRandomNumbers();
        correctAnswer = numberOne + numberTwo;

        Debug.Log(numberOne + " + " + numberTwo + " = " + correctAnswer);

        GenerateDummyAnswers();
    }

    void GenerateSubtraction()
    {
        numberOne = GetRandomNumbers();
        numberTwo = GetRandomNumbers();
        correctAnswer = numberOne - numberTwo;

        Debug.Log(numberOne + " - " + numberTwo + " = " + correctAnswer);

        GenerateDummyAnswers();
    }

    void GenerateDivision()
    {
        numberOne = GetRandomNumbers();
        numberTwo = GetRandomNumbers();
        correctAnswer = numberOne / numberTwo;
        correctAnswer = Mathf.RoundToInt(correctAnswer);
        Debug.Log(numberOne + " / " + numberTwo + " = " + correctAnswer);
        GenerateDummyAnswers();
    }

    /// <summary>
    /// Gets a random number based on our difficulty
    /// </summary>
    /// <returns>A random number</returns>
    int GetRandomNumbers()
    {
        switch (difficulty)
        {
            case Difficulty.EASY:
                return (Random.Range(1, 10));
            case Difficulty.MEDIUM:
                return (Random.Range(1, 20));
            case Difficulty.HARD:
                return (Random.Range(1, 100));
            default:
                return (Random.Range(1, 10));
        }
    }

    /// <summary>
    /// This will generate a set of dummy answers
    /// </summary>
    private void GenerateDummyAnswers()
    {
        for (int i = 0; i < dummyAnswers.Count; i++)
        {
            int dummy;
            do
            {
                dummy = Random.Range(correctAnswer - 10, correctAnswer + 10);
            }
            while (dummy == correctAnswer || dummyAnswers.Contains(dummy));
            dummyAnswers[i] = dummy;
            Debug.Log("Dummy answer: " + dummyAnswers[i]);
        }
    }
    void UpdateInterface()
    {
        numberone.text = numberOne.ToString();
        numbertwo.text = numberTwo.ToString();
        // answer.text = correctAnswer.ToString();
        AnswerLocation();
    }

    void AnswerLocation()
    {
        //   int rndSpawn = Random.Range(0, answerPoints.Length);
        TMP_Text randomLoca = answerPoints[Random.Range(0, answerPoints.Length)];
        print(randomLoca);
     //   answerPoints.text = dummyAnswers.ToString();
        randomLoca.text = correctAnswer.ToString();
    }
}