using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WizardEnemy : EnemyBase
{
    protected override void Update()
    {
        base.Update();
        DoDamage();
    }
}
