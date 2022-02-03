using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEndGame : MonoBehaviour
{
    public GameOverBehaviour gameOverBehaviour;

    void Start()
    {
        gameOverBehaviour = GameObject.Find("GameOverBehaviour").GetComponent<GameOverBehaviour>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            throw new NotImplementedException();
        }
    }
}
