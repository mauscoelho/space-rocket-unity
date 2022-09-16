using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCrash : MonoBehaviour
{
    AudioSource fxSound; // Emitir sons    
    public AudioClip clip;
    public float volume = 0.5f;

    void Start()
    {
        // Audio Source responsavel por emitir os sons
        fxSound = GetComponent<AudioSource>();        
    }

    public void Crash()
    {
        fxSound.PlayOneShot(clip, volume);
    }
}
