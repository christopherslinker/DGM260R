using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    public GameObject powerUp;
    
    private float ySpawn = 0.75f;
    
    private float xSpawnRange = 870f;

    private float zHighRange = 2900f;

    private float zLowRange = 1500f;

    private float startDelay = 15f;
    
    public GameOverBehaviour gameOverBehaviour;

    void Start()
    {        
        InvokeRepeating("SpawnCollectable", startDelay, Random.Range(10f, 30f));
        gameOverBehaviour = GameObject.Find("GameOverBehaviour").GetComponent<GameOverBehaviour>();
    }

    void SpawnCollectable()
    {
        if (!gameOverBehaviour.gameIsOver)
        {
            float randomX = Random.Range(-xSpawnRange, xSpawnRange);
            float randomZ = Random.Range(zLowRange, zHighRange);
    
            var spawnPos = new Vector3(randomX, ySpawn, randomZ);
            Instantiate(powerUp, spawnPos, powerUp.gameObject.transform.rotation);
        }

    }
}
