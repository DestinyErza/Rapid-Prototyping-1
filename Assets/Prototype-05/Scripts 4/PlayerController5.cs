using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController5 : Singleton<PlayerController5>
{

    PanelManager PM;
    Timer TM;
  
    public GameObject pickupPanel;
    public GameObject hidden;
    public GameObject nothiding;
    public GameObject wolff;
    public GameObject humanf;
    public GameObject win;
    public GameObject lose;
    public GameObject goalprompt;
    public GameObject timewarning;

    public int Lightcount;
    public TMP_Text lighttext;
    public TMP_Text wolftimer;

    // Start is called before the first frame update
    void Start()
    {
        Lightcount = 1;
        wolff.SetActive(true);
        humanf.SetActive(false);
        goalprompt.SetActive(false);
        win.SetActive(false);
        lose.SetActive(false);
        hidden.SetActive(false);
        nothiding.SetActive(true);

        timewarning.SetActive(false);

        PM = PanelManager.instance;
        TM = Timer.instance;

        pickupPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        lighttext.text = Lightcount + "/6";
        wolftimer.text = TM.currentTime.ToString("F2");


        if (TM.currentTime >= 5)
        {
            timewarning.SetActive(true);
        }
            // if (TM.currentTime >= 5)
            // {
            //     lose.SetActive(true);
            // }

            if (Input.GetKey(KeyCode.Alpha1))
        {
            humanform();
          
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            wolfform();
           
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            PM.WolfC();
         
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
           
            PM.HidingC();
        }
    }

    private void OnTriggerEnter(Collider other)
    {



        if (other.gameObject.CompareTag("enemy + wolf"))
        {
            //hidden
        }

        if (other.gameObject.CompareTag("Event"))
        {
            PM.Hiding();
        }
        if (other.gameObject.CompareTag("wolfEvent"))
        {
            PM.Wolf();
        }
    }

    private void OnTriggerStay(Collider other)
    {
      

        if (other.gameObject.CompareTag("hiding"))
        {
            //hidden
            Debug.Log("hidden");
            hidden.SetActive(true);
            nothiding.SetActive(false);
            Debug.Log("hidden");
        }
        else
        {
            hidden.SetActive(false);
            nothiding.SetActive(true);
        }

        if (other.gameObject.CompareTag("light"))
        {
            
            pickupPanel.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                Destroy(other.gameObject);
                //formPanel.SetActive(false);
                pickupPanel.SetActive(false);
                addlight();

            }
        }

        if (other.gameObject.CompareTag("Event1"))
        {
           if (Lightcount == 6)
            {
                win.SetActive(true);
            }
            else
            {
                goalprompt.SetActive(true);
            }
           
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.CompareTag("light"))
        {
            pickupPanel.SetActive(false);
        }

        if (other.gameObject.CompareTag("hiding"))
        {
            hidden.SetActive(false);
            nothiding.SetActive(true);
        }

        if (other.gameObject.CompareTag("Event1"))
        {
         
                goalprompt.SetActive(false);
        }

    }


    public void addlight()
    {
        Lightcount += 1;
        //+score
    }

    public void humanform()
    {
        TM.PauseTimer();
        wolff.SetActive(false);
        humanf.SetActive(true);
    }

    public void wolfform()
    {
        TM.ResumeTimer();
        wolff.SetActive(true);
        humanf.SetActive(false);
    }
}
