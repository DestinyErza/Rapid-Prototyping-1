using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AntManager : MonoBehaviour
{

    EquationGenerator EG;

    public GameObject ant1;
    public GameObject ant2;
    public GameObject ant3;
    public GameObject ant4;
    public GameObject ant5;
    public GameObject ant6;
    public GameObject ant7;
    public GameObject ant8;
    public GameObject ant9;
    public GameObject ant10;
    public GameObject ant11;
    public GameObject ant12;
    public GameObject ant13;
    public GameObject ant14;
    public GameObject ant15;
    public GameObject ant16;
    public GameObject ant17;
    public GameObject ant18;
    public GameObject ant19;
    public GameObject ant20;
    public GameObject ant21;
    public GameObject ant22;
    public GameObject ant23;
    public GameObject ant24;
    public GameObject ant25;

    public Button button1;
    public Button button2;
    public Button button3;


    // Start is called before the first frame update
    void Start()
    {
        EG = EquationGenerator.instance;
        ant1.SetActive(true);
        ant2.SetActive(true);
        ant3.SetActive(true);
        ant4.SetActive(true);
        ant5.SetActive(true);
        ant6.SetActive(false);
        ant7.SetActive(false);
        ant8.SetActive(false);
        ant9.SetActive(false);
        ant10.SetActive(false);
        ant11.SetActive(false);
        ant12.SetActive(false);
        ant13.SetActive(false);
        ant14.SetActive(false);
        ant15.SetActive(false);
        ant16.SetActive(false);
        ant17.SetActive(false);
        ant18.SetActive(false);
        ant19.SetActive(false);
        ant20.SetActive(false);
        ant21.SetActive(false);
        ant22.SetActive(false);
        ant23.SetActive(false);
        ant24.SetActive(false);
        ant25.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        if (EG.Ascore == 0)
        {
            button1.interactable = false;
            button2.interactable = false;
            button3.interactable = false;

            ant1.SetActive(false);
            ant2.SetActive(false);
            ant3.SetActive(false);
            ant4.SetActive(false);
            ant5.SetActive(false);
            ant6.SetActive(false);
            ant7.SetActive(false);
            ant8.SetActive(false);
            ant9.SetActive(false);
            ant10.SetActive(false);
            ant11.SetActive(false);
            ant12.SetActive(false);
            ant13.SetActive(false);
            ant14.SetActive(false);
            ant15.SetActive(false);
            ant16.SetActive(false);
            ant17.SetActive(false);
            ant18.SetActive(false);
            ant19.SetActive(false);
            ant20.SetActive(false);
            ant21.SetActive(false);
            ant22.SetActive(false);
            ant23.SetActive(false);
            ant24.SetActive(false);
            ant25.SetActive(false);
        }

        if (EG.Ascore == 1)
        {
            button1.interactable = true;
            button2.interactable = false;
            button3.interactable = false;
            ant1.SetActive(true);

            ant2.SetActive(false);
            ant3.SetActive(false);
            ant4.SetActive(false);
            ant5.SetActive(false);
            ant6.SetActive(false);
            ant7.SetActive(false);
            ant8.SetActive(false);
            ant9.SetActive(false);
            ant10.SetActive(false);
            ant11.SetActive(false);
            ant12.SetActive(false);
            ant13.SetActive(false);
            ant14.SetActive(false);
            ant15.SetActive(false);
            ant16.SetActive(false);
            ant17.SetActive(false);
            ant18.SetActive(false);
            ant19.SetActive(false);
            ant20.SetActive(false);
            ant21.SetActive(false);
            ant22.SetActive(false);
            ant23.SetActive(false);
            ant24.SetActive(false);
            ant25.SetActive(false);
        }

        if (EG.Ascore == 2)
        {


            button1.interactable = true;
            button2.interactable = true;
            button3.interactable = false;
            ant2.SetActive(true);

            ant3.SetActive(false);
            ant4.SetActive(false);
            ant5.SetActive(false);
            ant6.SetActive(false);
            ant7.SetActive(false);
            ant8.SetActive(false);
            ant9.SetActive(false);
            ant10.SetActive(false);
            ant11.SetActive(false);
            ant12.SetActive(false);
            ant13.SetActive(false);
            ant14.SetActive(false);
            ant15.SetActive(false);
            ant16.SetActive(false);
            ant17.SetActive(false);
            ant18.SetActive(false);
            ant19.SetActive(false);
            ant20.SetActive(false);
            ant21.SetActive(false);
            ant22.SetActive(false);
            ant23.SetActive(false);
            ant24.SetActive(false);
            ant25.SetActive(false);
        }

        if (EG.Ascore == 3)
        {

            button1.interactable = true;
            button2.interactable = true;
            button3.interactable = true;
            
            ant3.SetActive(true);

        
            ant4.SetActive(false);
            ant5.SetActive(false);
            ant6.SetActive(false);
            ant7.SetActive(false);
            ant8.SetActive(false);
            ant9.SetActive(false);
            ant10.SetActive(false);
            ant11.SetActive(false);
            ant12.SetActive(false);
            ant13.SetActive(false);
            ant14.SetActive(false);
            ant15.SetActive(false);
            ant16.SetActive(false);
            ant17.SetActive(false);
            ant18.SetActive(false);
            ant19.SetActive(false);
            ant20.SetActive(false);
            ant21.SetActive(false);
            ant22.SetActive(false);
            ant23.SetActive(false);
            ant24.SetActive(false);
            ant25.SetActive(false);
        }
        if (EG.Ascore == 4)
        {
            button1.interactable = true;
            button2.interactable = true;
            button3.interactable = true;
            ant4.SetActive(true);

            ant5.SetActive(false);
            ant6.SetActive(false);
            ant7.SetActive(false);
            ant8.SetActive(false);
            ant9.SetActive(false);
            ant10.SetActive(false);
            ant11.SetActive(false);
            ant12.SetActive(false);
            ant13.SetActive(false);
            ant14.SetActive(false);
            ant15.SetActive(false);
            ant16.SetActive(false);
            ant17.SetActive(false);
            ant18.SetActive(false);
            ant19.SetActive(false);
            ant20.SetActive(false);
            ant21.SetActive(false);
            ant22.SetActive(false);
            ant23.SetActive(false);
            ant24.SetActive(false);
            ant25.SetActive(false);
        }
        if (EG.Ascore == 5)
        {
            button1.interactable = true;
            button2.interactable = true;
            button3.interactable = true;
            ant5.SetActive(true);

            ant6.SetActive(false);
            ant7.SetActive(false);
            ant8.SetActive(false);
            ant9.SetActive(false);
            ant10.SetActive(false);
            ant11.SetActive(false);
            ant12.SetActive(false);
            ant13.SetActive(false);
            ant14.SetActive(false);
            ant15.SetActive(false);
            ant16.SetActive(false);
            ant17.SetActive(false);
            ant18.SetActive(false);
            ant19.SetActive(false);
            ant20.SetActive(false);
            ant21.SetActive(false);
            ant22.SetActive(false);
            ant23.SetActive(false);
            ant24.SetActive(false);
            ant25.SetActive(false);
        }
        if (EG.Ascore == 6)
        {
            button1.interactable = true;
            button2.interactable = true;
            button3.interactable = true;
            ant6.SetActive(true);

            ant7.SetActive(false);
            ant8.SetActive(false);
            ant9.SetActive(false);
            ant10.SetActive(false);
            ant11.SetActive(false);
            ant12.SetActive(false);
            ant13.SetActive(false);
            ant14.SetActive(false);
            ant15.SetActive(false);
            ant16.SetActive(false);
            ant17.SetActive(false);
            ant18.SetActive(false);
            ant19.SetActive(false);
            ant20.SetActive(false);
            ant21.SetActive(false);
            ant22.SetActive(false);
            ant23.SetActive(false);
            ant24.SetActive(false);
            ant25.SetActive(false);
        }
        if (EG.Ascore == 7)
        {
            button1.interactable = true;
            button2.interactable = true;
            button3.interactable = true;
            ant7.SetActive(true);

            ant8.SetActive(false);
            ant9.SetActive(false);
            ant10.SetActive(false);
            ant11.SetActive(false);
            ant12.SetActive(false);
            ant13.SetActive(false);
            ant14.SetActive(false);
            ant15.SetActive(false);
            ant16.SetActive(false);
            ant17.SetActive(false);
            ant18.SetActive(false);
            ant19.SetActive(false);
            ant20.SetActive(false);
            ant21.SetActive(false);
            ant22.SetActive(false);
            ant23.SetActive(false);
            ant24.SetActive(false);
            ant25.SetActive(false);
        }

        if (EG.Ascore == 8)
        {
            button1.interactable = true;
            button2.interactable = true;
            button3.interactable = true;
            ant8.SetActive(true);

            ant9.SetActive(false);
            ant10.SetActive(false);
            ant11.SetActive(false);
            ant12.SetActive(false);
            ant13.SetActive(false);
            ant14.SetActive(false);
            ant15.SetActive(false);
            ant16.SetActive(false);
            ant17.SetActive(false);
            ant18.SetActive(false);
            ant19.SetActive(false);
            ant20.SetActive(false);
            ant21.SetActive(false);
            ant22.SetActive(false);
            ant23.SetActive(false);
            ant24.SetActive(false);
            ant25.SetActive(false);
        }
        if (EG.Ascore == 9)
        {
            button1.interactable = true;
            button2.interactable = true;
            button3.interactable = true;
            ant9.SetActive(true);

            ant10.SetActive(false);
            ant11.SetActive(false);
            ant12.SetActive(false);
            ant13.SetActive(false);
            ant14.SetActive(false);
            ant15.SetActive(false);
            ant16.SetActive(false);
            ant17.SetActive(false);
            ant18.SetActive(false);
            ant19.SetActive(false);
            ant20.SetActive(false);
            ant21.SetActive(false);
            ant22.SetActive(false);
            ant23.SetActive(false);
            ant24.SetActive(false);
            ant25.SetActive(false);
        }
        if (EG.Ascore == 10)
        {
            button1.interactable = true;
            button2.interactable = true;
            button3.interactable = true;
            ant10.SetActive(true);

            ant11.SetActive(false);
            ant12.SetActive(false);
            ant13.SetActive(false);
            ant14.SetActive(false);
            ant15.SetActive(false);
            ant16.SetActive(false);
            ant17.SetActive(false);
            ant18.SetActive(false);
            ant19.SetActive(false);
            ant20.SetActive(false);
            ant21.SetActive(false);
            ant22.SetActive(false);
            ant23.SetActive(false);
            ant24.SetActive(false);
            ant25.SetActive(false);
        }
        if (EG.Ascore == 11)
        {
            ant11.SetActive(true);

            ant12.SetActive(false);
            ant13.SetActive(false);
            ant14.SetActive(false);
            ant15.SetActive(false);
            ant16.SetActive(false);
            ant17.SetActive(false);
            ant18.SetActive(false);
            ant19.SetActive(false);
            ant20.SetActive(false);
            ant21.SetActive(false);
            ant22.SetActive(false);
            ant23.SetActive(false);
            ant24.SetActive(false);
            ant25.SetActive(false);
        }
        if (EG.Ascore == 12)
        {
            ant12.SetActive(true);

            ant13.SetActive(false);
            ant14.SetActive(false);
            ant15.SetActive(false);
            ant16.SetActive(false);
            ant17.SetActive(false);
            ant18.SetActive(false);
            ant19.SetActive(false);
            ant20.SetActive(false);
            ant21.SetActive(false);
            ant22.SetActive(false);
            ant23.SetActive(false);
            ant24.SetActive(false);
            ant25.SetActive(false);
        }
        if (EG.Ascore == 13)
        {
            ant13.SetActive(true);

            ant14.SetActive(false);
            ant15.SetActive(false);
            ant16.SetActive(false);
            ant17.SetActive(false);
            ant18.SetActive(false);
            ant19.SetActive(false);
            ant20.SetActive(false);
            ant21.SetActive(false);
            ant22.SetActive(false);
            ant23.SetActive(false);
            ant24.SetActive(false);
            ant25.SetActive(false);
        }
        if (EG.Ascore == 14)
        {
            ant14.SetActive(true);

            ant15.SetActive(false);
            ant16.SetActive(false);
            ant17.SetActive(false);
            ant18.SetActive(false);
            ant19.SetActive(false);
            ant20.SetActive(false);
            ant21.SetActive(false);
            ant22.SetActive(false);
            ant23.SetActive(false);
            ant24.SetActive(false);
            ant25.SetActive(false);
        }
        if (EG.Ascore == 15)
        {
            ant15.SetActive(true);

            ant16.SetActive(false);
            ant17.SetActive(false);
            ant18.SetActive(false);
            ant19.SetActive(false);
            ant20.SetActive(false);
            ant21.SetActive(false);
            ant22.SetActive(false);
            ant23.SetActive(false);
            ant24.SetActive(false);
            ant25.SetActive(false);
        }
        if (EG.Ascore == 16)
        {
            ant16.SetActive(true);

            ant17.SetActive(false);
            ant18.SetActive(false);
            ant19.SetActive(false);
            ant20.SetActive(false);
            ant21.SetActive(false);
            ant22.SetActive(false);
            ant23.SetActive(false);
            ant24.SetActive(false);
            ant25.SetActive(false);
        }
        if (EG.Ascore == 17)
        {
            ant17.SetActive(true);

            ant18.SetActive(false);
            ant19.SetActive(false);
            ant20.SetActive(false);
            ant21.SetActive(false);
            ant22.SetActive(false);
            ant23.SetActive(false);
            ant24.SetActive(false);
            ant25.SetActive(false);
        }
        if (EG.Ascore == 18)
        {
            ant18.SetActive(true);

            ant19.SetActive(false);
            ant20.SetActive(false);
            ant21.SetActive(false);
            ant22.SetActive(false);
            ant23.SetActive(false);
            ant24.SetActive(false);
            ant25.SetActive(false);
        }
        if (EG.Ascore == 19)
        {
            ant19.SetActive(true);

            ant20.SetActive(false);
            ant21.SetActive(false);
            ant22.SetActive(false);
            ant23.SetActive(false);
            ant24.SetActive(false);
            ant25.SetActive(false);
        }
        if (EG.Ascore == 20)
        {
            ant20.SetActive(true);

            ant21.SetActive(false);
            ant22.SetActive(false);
            ant23.SetActive(false);
            ant24.SetActive(false);
            ant25.SetActive(false);
        }
        if (EG.Ascore == 21)
        {
            ant21.SetActive(true);

        
            ant22.SetActive(false);
            ant23.SetActive(false);
            ant24.SetActive(false);
            ant25.SetActive(false);
        }
        if (EG.Ascore == 22)
        {
            ant22.SetActive(true);

            ant23.SetActive(false);
            ant24.SetActive(false);
            ant25.SetActive(false);
        }
        if (EG.Ascore == 23)
        {
            ant23.SetActive(true);

            ant24.SetActive(false);
            ant25.SetActive(false);
        }
        if (EG.Ascore == 24)
        {
            ant24.SetActive(true);

            ant25.SetActive(false);
        }
        if (EG.Ascore == 25)
        {
            ant25.SetActive(true);

        }

    }






}
