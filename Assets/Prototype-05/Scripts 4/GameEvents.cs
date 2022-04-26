using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvents : MonoBehaviour
{
    public static Action<GameObject> OnEnemyHit = null;
    public static Action<GameObject> OnEnemyDied = null;
    public static Action<GameObject> OnPlayerHit = null;
    public static Action<GameObject> OnPlayerDied = null;
    

    public static void ReportEnemyHit(GameObject _enemy)
    {
        Debug.Log("Enemy" + _enemy.name + "was hit");
        OnEnemyHit?.Invoke(_enemy);
    }

    public static void ReportEnemyDied(GameObject _enemy)
    {
        Debug.Log("Enemy" + _enemy.name + "died");
        OnEnemyDied?.Invoke(_enemy);
    }


    public static void ReportPlayerHit(GameObject _Player)
    {

        OnEnemyHit?.Invoke(_Player);
    }

    public static void ReportPlayerDied(GameObject _Player)
    {

        OnEnemyDied?.Invoke(_Player);
      
    }

 
}
