using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster_controlled : Singleton<monster_controlled>
{
    public float waitTime = 1;
    public float moveSpeed = 2;
    public Transform[] moveToPositions;
    int currentPosition = 0;

    private void Start()
    {

    }

    public void startmove()
    {
        StartCoroutine(MoveInDirection());
    }




    //controls movement from one point to another
    IEnumerator MoveInDirection()
    {
        Vector3 _newPos = moveToPositions[currentPosition].position;
        while (Vector3.Distance(transform.position, _newPos) > 0.1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, _newPos, moveSpeed * Time.deltaTime);
            yield return null;
        }
        //makes it loop through all points
        yield return new WaitForSeconds(waitTime);

        if (currentPosition != moveToPositions.Length - 1)
            currentPosition = currentPosition + 1;
        else
            currentPosition = 0;
        Destroy(gameObject);
    }

  
    
}
