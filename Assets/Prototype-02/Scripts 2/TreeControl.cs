using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeControl : GameBehaviour
{
    public GameObject basic;
    public GameObject positive1;
    public GameObject positive2;
    public GameObject neative1;
    public GameObject negative2;

    void Start()
    {
        basic.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (_PC1.score >= 1)
        {
            basic.SetActive(true);
        }

        if (_PC1.score <= 1)
        {
           basic.SetActive(false);
        }
    }
}
