using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSpan : MonoBehaviour
{

    public float lifeSpan = 2.0f;


    // Update is called once per frame
    void Update()
    {
        if (Time.deltaTime > lifeSpan)
        {
            Destroy(gameObject);
        }
        
    }
}
