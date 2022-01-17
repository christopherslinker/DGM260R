using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSpan : MonoBehaviour
{
    public float lifeSpan;


   // private void DestroyObject()
   // {
       // if (Time.deltaTime == lifeSpan)
       // {
         //   DestroyObject();
        //}
    //}
    

    public void Update()
    {
        if (Time.time > lifeSpan)
        {
            Destroy(gameObject);
        }
    }
}
