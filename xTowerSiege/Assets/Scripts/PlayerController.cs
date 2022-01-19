using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Color;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;

    private float verticalInput;

    private float speed = 5.0f;

    private float xRange = 4f;

    private float zRange = 8.5f;
    
    
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
                transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
                
                verticalInput = Input.GetAxis("Vertical");
                transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
    }
}
