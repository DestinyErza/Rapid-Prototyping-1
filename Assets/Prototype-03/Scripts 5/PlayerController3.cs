using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController3 : GameBehaviour
{
    public GameObject chicken;
    public GameObject friedchicken;

    ///pivot controls!!!!!
    ///
    private void Start()
    {
        friedchicken.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("plot"))
        {
            _PM.plant();
        }

        if (other.CompareTag("chicken"))
        {
            chicken.SetActive(false);
            friedchicken.SetActive(true);
        }
    }
}


