using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float HitPoints = 100f;

    // create public method which reduces hitpoints by the amount of damage

    public void TakeDamage(float Damage)
    {

        HitPoints -= Damage;

        if (HitPoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
