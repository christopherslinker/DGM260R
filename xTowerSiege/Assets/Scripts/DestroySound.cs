using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySound : MonoBehaviour
{

    public AudioSource bangSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ammo"))
        {
            bangSound.Play();
        }
    }
}
