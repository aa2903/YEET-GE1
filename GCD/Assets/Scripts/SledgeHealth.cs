using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SledgeHealth : MonoBehaviour
{

    [SerializeField] float HitPoints = 100f;

   

    bool isDead = false;
    // create public method which reduces hitpoints by the amount of damage

    public void TakeDamage(float Damage)
    {


        HitPoints -= Damage;

        if (HitPoints <= 0 && !isDead)
        {
            Destroy(gameObject);

           
            
            isDead = true;
        }


    }
}
