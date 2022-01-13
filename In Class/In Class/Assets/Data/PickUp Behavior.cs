using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBehavior : MonoBehaviour
{
    public event EventHandler onSpacePress;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //onSpacePress(this, EventArgs.Empty);
            onSpacePress?.Invoke(this, EventArgs.Empty);
        }
    }

    private void OnEnable()
    {
        onSpacePress += TestEvent;
    }

    void TestEvent(object sender, EventArgs e)
    {
        Debug.Log("Event Fired");
    }
}
