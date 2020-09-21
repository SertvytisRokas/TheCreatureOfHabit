using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControllerLVL1 : MonoBehaviour
{
    private AudioSource source;
    private float musicVolume = 1f;
    int count = 0;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void Update()
    {
        source.volume = musicVolume;

    }

    public void setVolume(float volume) {
        musicVolume = volume;

        count++;
    }
}
