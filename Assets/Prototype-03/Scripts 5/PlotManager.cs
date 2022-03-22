using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotManager : Singleton<PlotManager>
{
    bool isPlanted = false;
    bool isWatered = false;
    bool isEmpty = false;
    bool isWaterable = false;

    public GameObject crop;
    public GameObject watered;
    public GameObject plot;

  //  public Sprite[] plantstages;
 //   int plantStage = 0;
    float waitTime = 2f;
    float timer;

    void Start()
    {
       
        crop.SetActive(true);
        watered.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlanted)
        {
            bool isWaterable = true;
        }

        if(isWatered)
        {
            isWatered = true;
        }

    }

   public void Water()
    {
        crop.SetActive(false);
        watered.SetActive(true);
    }

  public void Harvest()
    {
        crop.SetActive(false);
        watered.SetActive(false);
    }

    public void plant()
    {
        if (isEmpty)
        {
            isPlanted = true;
            crop.SetActive(true);
        }
    }

    void updatePlant()
    {
        //crop image is = to plantstages

        //not rlly needed
    }
}
