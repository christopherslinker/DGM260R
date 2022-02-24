using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    public GameObject powerUp;
    
    private float ySpawn = 0.75f;
    
    private float xSpawnRange = 870f;

    private float zSpawnRange = 719f;

    private float startDelay = 3.0f;

    private float powerUpSpawnTime = 3.0f;

    public GameOverBehaviour gameOverBehaviour;

    void Start()
    {        
        InvokeRepeating("SpawnCollectable", startDelay, powerUpSpawnTime);
        gameOverBehaviour = GameObject.Find("GameOverBehaviour").GetComponent<GameOverBehaviour>();
    }

    void SpawnCollectable()
    {
        if (gameOverBehaviour.gameIsOver)
        {
            float randomX = Random.Range(-xSpawnRange, xSpawnRange);
            float randomZ = Random.Range(-zSpawnRange, zSpawnRange);
    
            var spawnPos = new Vector3(randomX, ySpawn, randomZ);
            Instantiate(powerUp, spawnPos, powerUp.gameObject.transform.rotation);
        }

    }
}
