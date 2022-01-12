using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : CylinderBase
{
    private void FixedUpdate()
    {
        transform.Translate(.1f, 0, 0);
    }
}
