using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extinguishable : MonoBehaviour
{
    public ParticleSystem fireParticles; // Partikel api yang akan dimatikan
    private bool isExtinguished = false;

    private void OnTriggerEnter(Collider other)
    {
        if (isExtinguished) return; // Jika sudah dimatikan, keluar dari fungsi

        if (other.CompareTag("Extinguisher")) // Pastikan objek yang bersentuhan adalah pemadam api
        {
            ExtinguishFire();
        }
    }

    void ExtinguishFire()
    {
        // Matikan partikel api
        fireParticles.Stop();

        // Tambahkan logika lain jika diperlukan, misalnya, menonaktifkan collider objek ini

        isExtinguished = true;
    }
}
