using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProgressWall : MonoBehaviour
{

    public TMP_Text PWall;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("progresswall");
            PWall.text = "";
            ResetText();
        }
        
    }

    IEnumerator ResetText()
    {
        yield return new WaitForSeconds(2);
        PWall.text = "";
    }
}
