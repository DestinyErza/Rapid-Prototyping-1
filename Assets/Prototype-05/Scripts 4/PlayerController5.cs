using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController5 : Singleton<PlayerController5>
{

    PanelManager PM;
    Timer TM;
    EnemyManager EM;
    monster_controlled MC;
  
    public GameObject pickupPanel;
    public GameObject hidden;
    public GameObject nothiding;
    public GameObject wolff;
    public GameObject humanf;
    public GameObject win;
    public GameObject lose;
    public GameObject wlose;
    public GameObject goalprompt;
    public GameObject timewarning;
    public GameObject rocks;
    public GameObject hurtPanel;

    public int Lightcount;
    public TMP_Text lighttext;
    public TMP_Text wolftimer;


    public int health;
    public bool wolf = false;
    public bool hiding = false;
    public GameObject health0;
    public GameObject health1;
    public GameObject health2;
    public GameObject health3;
    public GameObject health4;
    public GameObject health5;
    // Start is called before the first frame update
    void Start()
    {
        PM = PanelManager.instance;
        TM = Timer.instance;
        EM = EnemyManager.instance;
        MC = monster_controlled.instance;

        health = 5;

        Lightcount = 1;
        wolff.SetActive(true);
        humanf.SetActive(false);
        goalprompt.SetActive(false);
        win.SetActive(false);
        lose.SetActive(false);
        wlose.SetActive(false);
        hidden.SetActive(false);
        nothiding.SetActive(true);
        rocks.SetActive(false);
        timewarning.SetActive(false);
        pickupPanel.SetActive(false);

        health0.SetActive(false);
        health1.SetActive(false);
        health2.SetActive(false);
        health3.SetActive(false);
        health4.SetActive(false);
        health5.SetActive(true);

        hurtPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
   
        lighttext.text = Lightcount + "/6";
        wolftimer.text = TM.currentTime.ToString("F2");


        if (TM.currentTime >= 7)
        {
            timewarning.SetActive(true);
        }
        if (TM.currentTime >= 15)
        {
            wlose.SetActive(true);
        }

        if (Input.GetKey(KeyCode.Alpha1))
        {
            humanform();
            wolf = false;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            wolfform();
            wolf = true;
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            PM.WolfC();
        }
        if (Input.GetKey(KeyCode.Alpha3))
        { 
            PM.HidingC();
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            Debug.Log("press6");
            StartCoroutine( EM.SpawnWithDelay());
        }

        if (health == 0)
        {
            lose.SetActive(true);
        }
        if (health == 1)
        {
            health0.SetActive(false);
            health1.SetActive(true);
            health2.SetActive(false);
            health3.SetActive(false);
            health4.SetActive(false);
            health5.SetActive(false);
        }
        if (health == 2)
        {
            health0.SetActive(false);
            health1.SetActive(false);
            health2.SetActive(true);
            health3.SetActive(false);
            health4.SetActive(false);
            health5.SetActive(false);
        }
        if (health == 3)
        {
            health0.SetActive(false);
            health1.SetActive(false);
            health2.SetActive(false);
            health3.SetActive(true);
            health4.SetActive(false);
            health5.SetActive(false);
        }
        if (health == 4)
        {
            health0.SetActive(false);
            health1.SetActive(false);
            health2.SetActive(false);
            health3.SetActive(false);
            health4.SetActive(true);
            health5.SetActive(false);
        }
        if (health == 5)
        {
            health0.SetActive(false);
            health1.SetActive(false);
            health2.SetActive(false);
            health3.SetActive(false);
            health4.SetActive(false);
            health5.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            health -= 1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Enemy"))
        {
            if (wolf == true)
            {
                Destroy(other.gameObject);
                EM.KillEnemy(other.gameObject);
            }
            else if(wolf == false)
            {
                health -= 1;
              
                StartCoroutine(hurtpanel());
            }
            // if(bool for wolf)
          
        }

        if (other.gameObject.CompareTag("Event"))
        {
            PM.Hiding();
            MC.startmove();
        }
        if (other.gameObject.CompareTag("wolfEvent"))
        {
            PM.Wolf();
        }
    }

   public IEnumerator hurtpanel()
    {

        hurtPanel.SetActive(true);

        yield return new WaitForSeconds(1);

        hurtPanel.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
      

        if (other.gameObject.CompareTag("hiding"))
        {
            //hidden
           // Debug.Log("hidden");
            hidden.SetActive(true);
            nothiding.SetActive(false);
            //Debug.Log("hidden");
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
        if (other.gameObject.CompareTag("Event2"))
        {
            rocks.SetActive(true);
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
