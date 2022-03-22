using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{

    public GameObject crop;
    public GameObject watered;


    private void Start()
    {
   
        crop.SetActive(true);
        watered.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
           water();
        }
    }

    public void water()
    {
        crop.SetActive(false);
        watered.SetActive(true);
    }
}
