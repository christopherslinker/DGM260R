using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSpan : MonoBehaviour
{
    public float lifeSpan;
    
    public void Update()
    {
        if (Time.time > lifeSpan)
        {
            Destroy(gameObject);
        }
    }
}
