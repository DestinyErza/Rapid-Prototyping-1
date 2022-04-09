using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EquationGenerator : Singleton<EquationGenerator>
{
    public enum Difficulty { EASY, MEDIUM, HARD }

    public Difficulty difficulty;

    public int numberOne;
    public int numberTwo;
    public int correctAnswer;


    public TMP_Text symbol;
    public TMP_Text numberone;
    public TMP_Text numbertwo;

    public TMP_Text answerA;
    public TMP_Text answerD;
    public TMP_Text answerM;
    public TMP_Text AscoreText;
    public TMP_Text DscoreText;
    public TMP_Text MscoreText;


    public GameObject additionpanel;
    public GameObject divisionpanel;
    public GameObject multiplypanel;

    public int Ascore;
    public int Dscore;
    public int Mscore;


    public bool activequestion = false;

    public TMP_Text[] answerPoints;

    public List<int> dummyAnswers;

    private void Start()
    {
        InvokeRepeating("EatFood", 2.0f, 3f);

        additionpanel.SetActive(false);
        multiplypanel.SetActive(false);
        divisionpanel.SetActive(false);

        Ascore = 20;
        Dscore = 0;
        Mscore = 20;
    }
   

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

        AscoreText.text = "score: " + Ascore;
        DscoreText.text = "score: " + Dscore;
        MscoreText.text = "score: " + Mscore;
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

    public void GenerateMultiplication()
    {
        if (activequestion == false)
        {
            numberOne = GetRandomNumbers();
            numberTwo = GetRandomNumbers();
            correctAnswer = numberOne * numberTwo;

            Debug.Log(numberOne + " x " + numberTwo + " = " + correctAnswer);

            GenerateDummyAnswers();
            symbol.text = "X";
            UpdateInterface();

            activequestion = true;
            multiplypanel.SetActive(true);
        }

    }

    public void GenerateAddition()
    {
        if (activequestion == false)
        {
            numberOne = GetRandomNumbers();
            numberTwo = GetRandomNumbers();
            correctAnswer = numberOne + numberTwo;

            Debug.Log(numberOne + " + " + numberTwo + " = " + correctAnswer);

            GenerateDummyAnswers();
            symbol.text = "+";
            activequestion = true;
            additionpanel.SetActive(true);
            UpdateInterface();
        }
    }

    public void GenerateSubtraction()
    {
        numberOne = GetRandomNumbers();
        numberTwo = GetRandomNumbers();
        correctAnswer = numberOne - numberTwo;

        Debug.Log(numberOne + " - " + numberTwo + " = " + correctAnswer);

        GenerateDummyAnswers();

    }

    public void GenerateDivision()
    {
        if (activequestion == false)
        {
            numberOne = GetRandomNumbers();
            numberTwo = GetRandomNumbers();
            correctAnswer = numberOne / numberTwo;
            correctAnswer = Mathf.RoundToInt(correctAnswer);
            Debug.Log(numberOne + " / " + numberTwo + " = " + correctAnswer);


            GenerateDummyAnswers();
            symbol.text = "÷";
            activequestion = true;
            divisionpanel.SetActive(true);
            UpdateInterface();
        }
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
        answerD.text = correctAnswer.ToString();
        answerM.text = correctAnswer.ToString();
        answerA.text = correctAnswer.ToString();
     //   answerPoints.text = ""+ correctAnswer;
        // AnswerLocation();
    }

    void AnswerLocation()
    {
        //   int rndSpawn = Random.Range(0, answerPoints.Length);
        TMP_Text randomLoca = answerPoints[Random.Range(0, answerPoints.Length)];
        print(randomLoca);
        //   answerPoints.text = dummyAnswers.ToString();
        randomLoca.text = correctAnswer.ToString();
    }


    public void Division()
    {
        Dscore += 1;
        divisionpanel.SetActive(false);
        activequestion = false;
    }

    public void Multiply()
    {
        Mscore += 1;
        multiplypanel.SetActive(false);
        activequestion = false;
    }
    public void Addition()
    {

        additionpanel.SetActive(false);
        Ascore += 1;
        activequestion = false;

    }

    public void FalseAnswer()
    {
        additionpanel.SetActive(false);
        multiplypanel.SetActive(false);
        divisionpanel.SetActive(false);
        activequestion = false;
    }

    public void FalseAddition()
    {
        additionpanel.SetActive(false);
        Ascore -= 1;
        activequestion = false;
    }

    void EatFood()
    {
       Mscore -= 1;
        if (Mscore <= 1) ;
        {
         //   Mscore -= 1;
        }
    }
}