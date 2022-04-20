using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

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
    public TMP_Text answerS;
    public TMP_Text AscoreText;
    public TMP_Text DscoreText;
    public TMP_Text MscoreText;
    public TMP_Text scoretext;

    public TMP_Text answer1;
    public TMP_Text answer2;
    public TMP_Text answer3;
    public TMP_Text answer4;
    public TMP_Text answer5;
    public TMP_Text answer6;
    public TMP_Text answer7;
    public TMP_Text answer8;

    public GameObject additionpanel;
    public GameObject divisionpanel;
    public GameObject multiplypanel;
    public GameObject subtractionpanel;

    public int Ascore;
    public int Dscore;
    public int Mscore;
    public int score;

    public GameObject losepanel;
    public GameObject winpanel;

 

    public bool activequestion = false;

    public TMP_Text[] answerPoints;

    public List<int> dummyAnswers;



    private void Start()
    {
       
        InvokeRepeating("EatFood", 5.0f, 5f);
        InvokeRepeating("Attack", 10f, 10f);


        additionpanel.SetActive(false);
        multiplypanel.SetActive(false);
        divisionpanel.SetActive(false);
        subtractionpanel.SetActive(false);

        losepanel.SetActive(false);
        winpanel.SetActive(false);

        Ascore = 5;
        Dscore = 0;
        Mscore = 20;
    }
   

    void Update()
    {
        // Debug.Log(Dscore);
       ///  if (Input.GetKeyDown(KeyCode.Z))
       // { Division(); }
          


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


        if (Input.GetKeyDown(KeyCode.K))
        {
           Ascore += 1;
        }


        if (Input.GetKeyDown(KeyCode.L))
        {
            Ascore -= 1;
        }

        AscoreText.text = "score: " + Ascore + "/25";
        DscoreText.text = "score: " + Dscore + "/10";
        MscoreText.text = "score: " + Mscore;
        scoretext.text = "funds: " + score;
        //  if (Input.GetKeyDown(KeyCode.R))
        //      GenerateRandomEquation();
        //  UpdateInterface();

        if (Ascore == 0)
        {
            losepanel.SetActive(true);
           
        }
        if (Ascore == 2)
        {
         
        }
        if (Ascore == 3)
        {
          
        }
        if (Ascore == 4)
        {
           
        }
        if (Ascore == 5)
        {
            
        }

        if (Ascore == 25)
        {
            winpanel.SetActive(true);
        }

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
        if (activequestion == false && score >= 1)
        {
            numberOne = GetRandomNumbers();
            numberTwo = GetRandomNumbers();
            correctAnswer = numberOne + numberTwo;

            Debug.Log(numberOne + " + " + numberTwo + " = " + correctAnswer);

            GenerateDummyAnswers();
            symbol.text = "+";
            activequestion = true;
            additionpanel.SetActive(true);
            score -= 1;
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
        symbol.text = "-";
        activequestion = true;
        subtractionpanel.SetActive(true);
        UpdateInterface();

    }

    public void GenerateDivision()
    {
        if (activequestion == false)
        {
            numberOne = GetRandomDivision();
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

    int GetRandomDivision()
    {
        return (Random.Range(20, 30));
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
        answerS.text = correctAnswer.ToString();
        answer1.text = dummyAnswers[Random.Range(0, dummyAnswers.Count)].ToString();
        answer2.text = dummyAnswers[Random.Range(0, dummyAnswers.Count)].ToString();
        answer3.text = dummyAnswers[Random.Range(0, dummyAnswers.Count)].ToString();
        answer4.text = dummyAnswers[Random.Range(0, dummyAnswers.Count)].ToString();
        answer5.text = dummyAnswers[Random.Range(0, dummyAnswers.Count)].ToString();
        answer6.text = dummyAnswers[Random.Range(0, dummyAnswers.Count)].ToString();
        answer7.text = dummyAnswers[Random.Range(0, dummyAnswers.Count)].ToString();
        answer8.text = dummyAnswers[Random.Range(0, dummyAnswers.Count)].ToString();



        // answerPoints.text = ""+ correctAnswer;
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
        score += 1;
        divisionpanel.SetActive(false);
        activequestion = false;
    }

    public void Multiply()
    {
        Mscore += 1;
        multiplypanel.SetActive(false);
        score += 1;
        activequestion = false;
    }
    public void Addition()
    {

        additionpanel.SetActive(false);
        Ascore += 1;
       // score += 1;
        activequestion = false;
     
    }

    public void addfunds()
    {
        score += 3;
        subtractionpanel.SetActive(false);
        activequestion = false;
    }

    public void FalseAnswer()
    {
        additionpanel.SetActive(false);
        multiplypanel.SetActive(false);
        divisionpanel.SetActive(false);
        subtractionpanel.SetActive(false);
        activequestion = false;
    }

    public void FalseAddition()
    {
        additionpanel.SetActive(false);
       // Ascore -= 1;
        activequestion = false;
    }

    void EatFood()
    {
       Mscore -= 1;
        if (Mscore <= 1) 
        {
         //   Mscore -= 1;
        }
    }

    void Attack()
    {
        Ascore -= 1;
    }


}