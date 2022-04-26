using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableWall : MonoBehaviour
{
    public int health = 10;
    public GameObject Wall;

    void Start()
    {
        Wall.gameObject.SetActive(true);
    }

    public void ApplyDamage(int damage)
    {
        DamageCooldown();
        Debug.Log("Damaged");
        health -= damage;

        if (health <= 0)
        {
            Wall.gameObject.SetActive(false);
        }

        DamageCooldown();
    }

    void DamageCooldown()
    {

    }
}
