using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExtinguisher : MonoBehaviour
{
    public ParticleSystem extinguisherParticles;

    private bool isSpraying = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Menggunakan GetMouseButtonDown(0) untuk tombol kiri mouse
        {
            isSpraying = true;
            StartSpraying();
        }
        else if (Input.GetMouseButtonUp(0)) // Menggunakan GetMouseButtonUp(0) untuk melepaskan tombol kiri mouse
        {
            isSpraying = false;
            StopSpraying();
        }
    }

    void StartSpraying()
    {
        extinguisherParticles.Play();
    }

    void StopSpraying()
    {
        extinguisherParticles.Stop();
    }
}
