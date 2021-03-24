using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSFX : MonoBehaviour
{
    public AudioSource Jump;
    private void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump.Play();
           
        }
    }
}
