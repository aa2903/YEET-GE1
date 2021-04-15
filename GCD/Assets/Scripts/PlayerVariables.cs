using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVariables : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    // create public method which reduces hitpoints by the amount of damage

    public void TakeDamage(float Damage)
    {

        hitPoints -= Damage;

        if (hitPoints <= 0)

        {
            Debug.Log("You dead");
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 20), "hp: " + hitPoints);  //  Display the score on a label.
    }
}
