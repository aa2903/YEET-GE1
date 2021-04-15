using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float HitPoints = 100f;

    public Animator deathtrig;
    public AudioSource deathgroan;

    bool isDead = false;
    // create public method which reduces hitpoints by the amount of damage

    public void TakeDamage(float Damage)
    {


        HitPoints -= Damage;

        if (HitPoints <= 0 && !isDead)
        {
             Destroy(gameObject, 2f);

            deathtrig.SetTrigger("Death");
            deathgroan.Play();
            isDead = true;
        }
    }
}
