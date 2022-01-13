using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] private PickUpBehavior pickUp;
    public PlayerDataSO dataSO;
    [Header("Starting Values")]
    [SerializeField]private PlayerData data;

    private void Init()
    {
        dataSO.data = data;
    }

    private void Start()
    {
        Init();
    }

    private void PickUpAction()
    {
        dataSO.data.ammo += 1;
    }

    private void OnEnable()
    {
       //pickUp. += PickUpAction
    }

    private void OnDisable()
    {
        
    }
}
