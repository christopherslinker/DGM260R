using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    private float horizontalInput;

    private float verticalInput;

    private float xLowRange = -605f;

    private float xHighRange = 870f;

    private float zRange = 719f;
    
    
    void Update()
    {
        if (transform.position.x < xLowRange)
        {
            transform.position = new Vector3(xLowRange, transform.position.y, transform.position.z);
        }
        
        if (transform.position.x > xHighRange)
        {
            transform.position = new Vector3(xHighRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange );
        }
        
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
    }
}
