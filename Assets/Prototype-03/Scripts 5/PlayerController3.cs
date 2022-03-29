using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController3 : Singleton<PlayerController3>
{
    public GameObject chicken;
    public GameObject friedchicken;
    public GameObject friedchicken2;
    public GameObject friedchicken3;
    public GameObject friedchicken4;
    public GameObject friedchicken5;

    private Rigidbody playerRb;

    public float f_speed = 5;
    public float speed = 3.0f;
    // private float rot = 0.0f;

    
    public GameObject heart;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject heart4;
    public GameObject heart5;
    public int score;
    public int chickenscore;
    public TMP_Text scoreText;
    public TMP_Text chickenText;


    public GameObject flower;

    public GameObject flower1;

    public GameObject flower2;

    public GameObject flower3;

    public GameObject flower4;


    ///pivot controls!!!!!
    ///
    private void Start()
    {
        friedchicken.SetActive(false);
        playerRb = GetComponent<Rigidbody>();

        friedchicken.SetActive(false);
        heart.SetActive(true);
        friedchicken2.SetActive(false);
        heart2.SetActive(true);
        friedchicken3.SetActive(false);
        heart3.SetActive(true);
        heart4.SetActive(true);
        friedchicken5.SetActive(false);
        friedchicken4.SetActive(false);
        heart5.SetActive(true);


        flower.SetActive(false);
        flower2.SetActive(false);
        flower3.SetActive(false);
        flower4.SetActive(false);
   
        chickenscore = 0;
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.right * f_speed * Time.deltaTime);
        }
        transform.Rotate(0.0f, +Input.GetAxis ("Horizontal") * speed, 0.0f);
        scoreText.text = "score: " + score;
        chickenText.text = "chuickene: " + chickenscore;
        if (score == 1)
        {
            flower.SetActive(true);
        }
        if (score == 2)
        {
            flower2.SetActive(true);
        }
        if (score == 3)
        {
            flower3.SetActive(true);
        }
        if (score == 4)
        {
            flower4.SetActive(true);
        }
        if (score == 5)
        {
            flower1.SetActive(true);
            //winnnnn
        }


        ///chickrn
        ///
        if (chickenscore == 1)
        {
            friedchicken.SetActive(true);
            heart.SetActive(false);
        }

        if (chickenscore == 2)
        {
            friedchicken2.SetActive(true);
            heart2.SetActive(false);
        }
        if (chickenscore == 3)
        {
            friedchicken3.SetActive(true);
            heart3.SetActive(false);
        }
        if (chickenscore == 4)
        {
            friedchicken4.SetActive(true);
            heart4.SetActive(false);
        }
        if (chickenscore == 5)
        {
            friedchicken5.SetActive(true);
            heart5.SetActive(false);
            ////  GameObject ENF
        }
    }


     private void OnTriggerEnter(Collider other)
        {


            if (other.CompareTag("chicken"))
            {
              Destroy(other.gameObject);
              killchicken();
           
            } 
        }

   public void addscore()
    {
        score += 1;
    }

    public void killchicken()
    {
        chickenscore += 1;
    }
}



