using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController5 : Singleton<PlayerController5>
{

    public GameObject hidingPanel;
    public GameObject formPanel;
    public GameObject pickupPanel;
    // Start is called before the first frame update
    void Start()
    {
        hidingPanel.SetActive(false);
        formPanel.SetActive(false);
        pickupPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            
            formPanel.SetActive(false);
            
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            formPanel.SetActive(true);

        }
    }

    private void OnTriggerEnter(Collider other)
    {



        if (other.gameObject.CompareTag("enemy + wolf"))
        {
            //hidden
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("hiding"))
        {
            //hidden
            Debug.Log("hidden");
            hidingPanel.SetActive(true);
           
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
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("hiding"))
        {
            //hidden
            Debug.Log("hidden");
            hidingPanel.SetActive(false);

        }

        if (other.gameObject.CompareTag("light"))
        {

            pickupPanel.SetActive(false);


        }

        if (other.gameObject.CompareTag("Event"))
        {

          //stop player movement, have enemy move past 


        }
    }


    public void addlight()
    {
        //+score
    }
}
