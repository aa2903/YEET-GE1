using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 30f;
    public float range = 100f;
    public float fireRate = 15f;
    public AudioSource shootingSound;

    public Camera FPScamera;
    public ParticleSystem muzzleFlash;
    public ParticleSystem impactEffect;

    private float nextTimeToFire = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            
            if (!shootingSound.isPlaying && !muzzleFlash.isPlaying)
            {
                shootingSound.Play();
                muzzleFlash.Play();
                Shoot();
            }
            
        }
    }

    void Shoot()
    {
        
        RaycastHit hit;
        if (Physics.Raycast(FPScamera.transform.position, FPScamera.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }

            Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
        }

    }

}
