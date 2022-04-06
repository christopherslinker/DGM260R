using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeed = 10.0f;
    
    void Update()
    {
        transform.Rotate(Vector3.up, rotateSpeed);
        transform.Rotate(Vector3.left, rotateSpeed);
    }
}
