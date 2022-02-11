using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    public GameObject projectilePrefab;
    
    public float shootInterval = 1f;
    
    public float delay = 5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(ShootCannonBall),delay, shootInterval);
    }

    void ShootCannonBall()
    {
        Instantiate(projectilePrefab,transform.position, projectilePrefab.transform.rotation);
    }
    
}
