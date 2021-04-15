using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug; // For some reason Debug.Log stopped working > this is the workaround

public class Weapon : MonoBehaviour
{

    [SerializeField] Camera FPCamera;
    [SerializeField] float range = 100f;
    [SerializeField] float damage = 30f;

    // Inspector option for the muzzle flash
    [SerializeField] ParticleSystem muzzleFlash;
    
    [SerializeField] GameObject bullet;

    public Transform firePoint;
    

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            muzzleFlash.Play();
            Shoot();

        } 
    }

    private void Shoot()
    {
        // Instantiate a bullet prefab
        Instantiate(bullet, firePoint.position, firePoint.rotation);

        // Raycasting for the gun
        RaycastHit hit;
        if (Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, range))
        {
            Debug.Log("I hit this " + hit.transform.name);
            // To do: add some hit effect for visual players.
            
            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
            if (target == null)
            { 
                return;
            }
            target.TakeDamage(damage);
        }
        else
        {
            return;
        }




    }
}
