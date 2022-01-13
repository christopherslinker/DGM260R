using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyPrefab;

    private float spawnRangeX = 4;

    private float SpawnPosZ = 7524f;

    private float startDelay = 2;

    public float startInterval = 3.0f;
    

    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAsteroid), startDelay, startInterval);
    }
    
    private void SpawnRandomAsteroid ()
    {
        var spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, SpawnPosZ);
                
        int enemyIndex = Random.Range(0, enemyPrefab.Length);
                
        Instantiate(enemyPrefab [enemyIndex], spawnPos,
            enemyPrefab [enemyIndex].transform.rotation);
        
    }
}
