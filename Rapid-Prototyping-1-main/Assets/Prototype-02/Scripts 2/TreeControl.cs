using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeControl : GameBehaviour
{
    public GameObject basic;
    public GameObject B1;
    public GameObject B2;
    public GameObject B3;
    public GameObject B4;
    public GameObject B5;
    public GameObject B6;




    /// <summary>
    /// /ADD ONE FOR EACH  + SCORE INSTEAD OF DRYING LMAO,, MAYA MODEL
    /// </summary>
    void Start()
    {
        basic.SetActive(true);
        B1.SetActive(false);
        B2.SetActive(false);
        B3.SetActive(false);
        B4.SetActive(false);
        B5.SetActive(false);
        B6.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (_PC1.score == 1)
        {
             B1.SetActive(true);

            basic.SetActive(false);
          
            B3.SetActive(false);
            B4.SetActive(false);
            B5.SetActive(false);
            B6.SetActive(false);
        }

        if (_PC1.score == 2)
        {
            B2.SetActive(true);
            basic.SetActive(false);
            B1.SetActive(false);
        
            B3.SetActive(false);
            B4.SetActive(false);
            B5.SetActive(false);
            B6.SetActive(false);

        }


        if (_PC1.score == 3)
        {
            B3.SetActive(true);
            basic.SetActive(false);
            B1.SetActive(false);
            B2.SetActive(false);
           
            B4.SetActive(false);
            B5.SetActive(false);
            B6.SetActive(false);

        }

        if (_PC1.score == 4)
        {
            B4.SetActive(true);
            basic.SetActive(false);
            B1.SetActive(false);
            B2.SetActive(false);
            B3.SetActive(false);
           
            B5.SetActive(false);
            B6.SetActive(false);

        }

        if (_PC1.score == 5)
        {
            B5.SetActive(true);
            basic.SetActive(false);
            B1.SetActive(false);
            B2.SetActive(false);
            B3.SetActive(false);
            B4.SetActive(false);


        }

        if (_PC1.score == 6)
        {
            B6.SetActive(true);
            basic.SetActive(false);
            B1.SetActive(false);
            B2.SetActive(false);
            B3.SetActive(false);
            B4.SetActive(false);
       
         

        }

    }
}
