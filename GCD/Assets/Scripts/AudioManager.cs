using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource BGMusic;

    private void Awake()
    {
        BGMusic.Play();

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(BGMusic);
            return;
        }

        DontDestroyOnLoad(BGMusic);
    }
}
