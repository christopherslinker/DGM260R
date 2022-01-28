using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyPrefab;

    public float spawnPosX = 500;

    public float SpawnPosZ = 7524f;

    public float startDelay = 2f;

    public float spawnInterval = 5.0f;
    

    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomEnemy), startDelay, spawnInterval);
    }
    
    private void SpawnRandomEnemy ()
    {
        var spawnPos = new Vector3(Random.Range(spawnPosX, -spawnPosX), 0, SpawnPosZ);
                
        int enemyIndex = Random.Range(0, enemyPrefab.Length);
                
        Instantiate(enemyPrefab [enemyIndex], spawnPos,
            enemyPrefab [enemyIndex].transform.rotation);
        
    }
}
