using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderBase : MonoBehaviour
{
    
    public Color cylinderColor = Color.red;


    public void Start()
    {
        YeeHaw();
    }

    public void Update()
    {
        transform.Rotate(1f, .5f, 2f);
    }

    public void YeeHaw()
    {
        Debug.Log("Yee-Haw");
    }
}
