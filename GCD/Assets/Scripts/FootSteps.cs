using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class FootSteps : MonoBehaviour
{
    CharacterController cc;
    [SerializeField] AudioSource SFX;
    

    

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cc.isGrounded == true && cc.velocity.magnitude > 6f && SFX.isPlaying == false)
        {
            SFX.Play();
           
        }

    }
}
