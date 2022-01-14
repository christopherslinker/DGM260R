using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCannonBall : MonoBehaviour
{
    public GameObject[] cannonBallPrefab;


    private void Start()
    {
    }

    private void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.E))
        {

            //Instantiate (cannonBallPrefab, transform.position + (transform.forward * 2), transform.rotation);
        }
    }
}