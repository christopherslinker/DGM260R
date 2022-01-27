using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 8400;
    private float lowBound = -2000;
    void Update()
    {
        if (transform.position.z > topBound)
        {
            gameObject.SetActive(false);
        }
        else if (transform.position.z < lowBound)
        {
            gameObject.SetActive(false);
        }
    }
}
