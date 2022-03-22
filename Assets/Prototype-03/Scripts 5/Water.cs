using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : GameBehaviour
{
    void Start()
    {
      
    }
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("waterable"))
        {
            _PM.Water();

        }
    }
}
