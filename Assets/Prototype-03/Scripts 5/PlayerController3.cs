using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController3 : Singleton<PlayerController3>
{
    public GameObject chicken;
    public GameObject friedchicken;

    private Rigidbody playerRb;

    public float f_speed = 5;
    public float speed = 3.0f;
   // private float rot = 0.0f;


    public int score;
    public TMP_Text scoreText;


    ///pivot controls!!!!!
    ///
    private void Start()
    {
        friedchicken.SetActive(false);
        playerRb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.right * f_speed * Time.deltaTime);
        }
        transform.Rotate(0.0f, +Input.GetAxis ("Horizontal") * speed, 0.0f);
        scoreText.text = "score: " + score;
    }


     private void OnTriggerEnter(Collider other)
        {


            if (other.CompareTag("chicken"))
            {
                chicken.SetActive(false);
                friedchicken.SetActive(true);
            } 
        }

   public void addscore()
    {
        score += 1;
    }
 
}



