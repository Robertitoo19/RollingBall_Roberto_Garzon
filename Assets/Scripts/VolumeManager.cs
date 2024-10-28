using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeManager : MonoBehaviour
{
    public AudioMixer AudioMixer;
    public void setVolume(float volume)
    {
        AudioMixer.SetFloat("Volume", volume);
    }
}
