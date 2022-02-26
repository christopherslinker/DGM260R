using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    public GameObject projectilePrefab;
    
    public float shootInterval = 1f;
    
    public float Startdelay = 2f;

    private GameOverBehaviour gameOverBehaviour;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(ShootCannonBall),Startdelay, shootInterval);
        gameOverBehaviour = GameObject.Find("GameOverBehaviour").GetComponent<GameOverBehaviour>();
    }

    void ShootCannonBall()
    {
        if (!gameOverBehaviour.gameIsOver)
        {
            Instantiate(projectilePrefab,transform.position, projectilePrefab.transform.rotation);
        }

    }
    
}
