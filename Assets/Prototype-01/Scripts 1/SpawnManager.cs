using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9;
        public Transform[] spawnPoints;

    public int enemyCount;
    public int waveNumber;

    public GameObject powerupPrefab;
    public GameObject InstaKill;
   



    //spawn from spawn points in waves

    /// <summary>
    /// spawns enemy at random spawn location using the instantiation of a prefab (+ one per each wave for both enemy and powerups) (waves triggered when enemy count = 0)
    /// </summary>
    void Start()
    {
        //(3) = enemieaToSpawn
        SpawnEnemyWave(waveNumber);
        Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
    }

    private void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if (enemyCount == 0)
        {
            waveNumber++; SpawnEnemyWave(waveNumber);
            Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);

            Instantiate(InstaKill, GenerateSpawnPosition(), InstaKill.transform.rotation);
        }
    }


    /// <summary>
    /// spawns enemy wave when enemies are cleared
    /// </summary>
    /// <param name="enemiesToSpawn"></param>
    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            int rndSpawn = Random.Range(0, spawnPoints.Length);
            Instantiate(enemyPrefab, spawnPoints[rndSpawn].position, enemyPrefab.transform.rotation);
        }
    }

    public Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
         float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
       
        return randomPos;
    }
}
