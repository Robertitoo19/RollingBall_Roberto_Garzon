using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;

    public AudioClip backGround;
    public AudioClip item;
    public AudioClip trampSaw;
    public AudioClip trampSpike;
    void Start()
    {

    }
    void Update()
    {
        
    }
    public void ReproducirSFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }
}
