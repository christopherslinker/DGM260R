using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBehaviour : MonoBehaviour
{
    private ObjectPool objectPool;

    private void Start()
    {
       // objectPool = GameObject.Find("ObjectPool").GetComponent<ObjectPool>();    
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ammo"))
        {
            Debug.Log("Power Up Triggered");
        }
    }
}
