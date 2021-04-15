using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JatimaticShot : MonoBehaviour
{

    public AudioSource Shootsound1;
    public AudioSource Shootsound2;
    CharacterController cc;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Shootsound1.Play();
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shootsound2.Play();
        }

    }
}
