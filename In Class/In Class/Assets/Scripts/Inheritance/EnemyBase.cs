using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    protected void Run()
    {
        Debug.Log("Run");
    }

    protected void DoDamage()
    {
        Debug.Log("Damage");
    }

    protected virtual void Update()
    {
        Run();
    }
}
