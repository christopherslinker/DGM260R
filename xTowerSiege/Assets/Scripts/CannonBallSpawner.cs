using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallSpawner : MonoBehaviour
{
    public GameObject[] cannonBall;
    private float startDelay = 3f;
    private float spawnInterval = 0.5f;

    private void Start()
    {
        //InvokeRepeating(nameof(SpawnCannonBall), startDelay, spawnInterval);
    }

    private void Update()
    {
       // if (Input.GetKeyDown(KeyCode.E))
        //{
           // Instantiate(cannonBall, transform.position, cannonBall.transform.rotation);
       // }
    }
}
