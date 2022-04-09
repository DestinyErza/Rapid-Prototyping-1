using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntManager : MonoBehaviour
{

    EquationGenerator EG;
    // Start is called before the first frame update
    void Start()
    {
        EG = EquationGenerator.instance;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (EG.Ascore == 1)
        {

        }
    }

   

  

    
}
