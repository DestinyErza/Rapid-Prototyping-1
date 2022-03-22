using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harvest : MonoBehaviour
{
  
   

    

    public GameObject crop;
    public GameObject watered;
    void Start()
    {
    
    }

 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
          
            watered.SetActive(false);
            crop.SetActive(true);
           
        }
    }
 

    
}
