using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : GameBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    private GameObject player;
    public Vector3 lookDirection;

 

    public int damage;

    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }


    /// <summary>
    /// directs Enemy towards player using Vector x speed
    /// </summary>
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;

        enemyRb.AddForce(lookDirection * speed);

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }

   // public  void OnCollisionEnter(Collision collision)
  //  {
   //     collision.gameObject.GetComponent<BreakableWall>().ApplyDamage(1);
  //  }

    public void OnCollisionStay(Collision collision)
    {
   
        collision.gameObject.GetComponent<BreakableWall>().ApplyDamage(1);

    }

   
}
