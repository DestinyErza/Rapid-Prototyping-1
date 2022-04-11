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

    public GameObject indicator;
    public GameObject winpanel;
    public GameObject losepanel;


    public GameObject flower;

    public GameObject flower1;

    public GameObject flower2;

    public GameObject flower3;

    public GameObject flower4;

    public GameObject crates1;
    public GameObject crates2;
    public GameObject crates3;
    public GameObject crates4;
    public GameObject crates5;
    public GameObject crates6;
    public GameObject crates7;
    public GameObject crates8;
    public GameObject crates9;
    public GameObject crates10;


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

        indicator.SetActive(false);
        winpanel.SetActive(false);
        losepanel.SetActive(false);


        flower.SetActive(false);
        flower2.SetActive(false);
        flower3.SetActive(false);
        flower4.SetActive(false);

        crates1.SetActive(false);
        crates2.SetActive(false);
        crates3.SetActive(false);
        crates4.SetActive(false);
        crates5.SetActive(false);
        crates6.SetActive(false);
        crates7.SetActive(false);
        crates8.SetActive(false);
        crates9.SetActive(false);
        crates10.SetActive(false);
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
            crates1.SetActive(true);
          

        }

        if (score >= 10)
        {

            crates2.SetActive(true);
            
        }
        if (score >= 15)
        {
            crates3.SetActive(true);
          

        }
        if (score >= 20)
        {

            crates4.SetActive(true);
           
        }
        if (score >= 25)
        {
            crates5.SetActive(true);
        }
        if (score >= 30)
        {

            crates6.SetActive(true);
        }
        if (score >= 35)
        {
            crates7.SetActive(true);

        }
        if (score >= 40)
        {
            crates8.SetActive(true);

        }
        if (score >= 45)
        {
            crates9.SetActive(true);

        }
        if (score >= 50)
        {
            indicator.SetActive(true);
            crates10.SetActive(true);

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
            losepanel.SetActive(false);
            ////  GameObject ENF
        }


        if (Input.GetKey(KeyCode.E))
        {
            winpanel.SetActive(true);
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



