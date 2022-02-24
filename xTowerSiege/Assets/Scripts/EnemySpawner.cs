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

    public GameOverBehaviour gameOverBehaviour;
    

    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomEnemy), startDelay, spawnInterval);
        gameOverBehaviour = GameObject.Find("GameOverBehaviour").GetComponent<GameOverBehaviour>();
    }
    
    private void SpawnRandomEnemy ()
    {
        if (gameOverBehaviour.gameIsOver)
        {
            var spawnPos = new Vector3(Random.Range(spawnPosX, -spawnPosX), 0, SpawnPosZ);
                
            int enemyIndex = Random.Range(0, enemyPrefab.Length);
                
            Instantiate(enemyPrefab [enemyIndex], spawnPos,
                enemyPrefab [enemyIndex].transform.rotation);
        }

        
    }
}
