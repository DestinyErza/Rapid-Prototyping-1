using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Harvest : GameBehaviour
{
  




    public GameObject crop;
    public GameObject watered;
    void Update()
    {
       
    }

 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            

            watered.SetActive(false);
            crop.SetActive(true);

            _PC3.addscore();
        }
     
    }


    }
