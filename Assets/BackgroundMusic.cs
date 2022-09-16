using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    AudioSource fxSound; // Emitir sons
    public AudioClip backMusic; // Som de fundo
    // Start is called before the first frame update
    void Start()
    {
        // Audio Source responsavel por emitir os sons
        fxSound = GetComponent<AudioSource>();
        fxSound.Play(30);
    }
    
}
