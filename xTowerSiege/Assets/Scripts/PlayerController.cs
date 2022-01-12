using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float rotateSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        //float rotateY = Input.GetAxis("Mouse Y") * rotateSpeed;
        //transform.RotateAround(Vector3.up, rotateY);
        
        //transform.Rotate(Vector3.up);
    }

    private void OnMouseDrag()
    {
        /*float rotateX = Input.GetAxis("Mouse X") * rotateSpeed * Mathf.Deg2Rad;
        float rotateY = Input.GetAxis("Mouse Y") * rotateSpeed * Mathf.Deg2Rad;
        transform.RotateAround(Vector3.up, -rotateX);*/
        
        transform.Rotate(Vector3.up * Time.deltaTime);
    }
}
