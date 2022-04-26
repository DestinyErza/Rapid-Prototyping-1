using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController5 : Singleton<PlayerController5>
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            //wolf
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            //gorl
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Hiding"))
        {
            //hidden
        }

        if (other.gameObject.CompareTag("light"))
        {
            //hidden
        }

        if (other.gameObject.CompareTag("enemy + wolf"))
        {
            //hidden
        }
    }
}
