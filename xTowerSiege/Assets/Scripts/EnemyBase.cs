using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
}
