using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableWalls : Singleton<BreakableWalls>
{
    public int health = 2;

    public GameObject Wall;
  //  public GameObject[] Wall;
 

    void Start()
    {
        Wall.gameObject.SetActive(true);
       // wall = GameObject.FindGameObjectsWithTag("BWall").GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Wall.gameObject.SetActive(false);
        }
    }

    public void ApplyDamage(int damage)
    {
        Debug.Log("Damaged");
        health -= damage;
    }



}
