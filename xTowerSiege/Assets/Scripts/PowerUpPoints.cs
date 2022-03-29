using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpPoints : MonoBehaviour
{
    private ScoreManager scoreManager;


    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ammo"))
        {
            scoreManager.UpdateScore(20);
        }
    }
}
