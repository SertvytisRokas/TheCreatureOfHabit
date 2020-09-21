using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControllerLVL3 : MonoBehaviour
{
    public AudioSource source1;
    public AudioSource source2;

    private float musicVolume = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BattleSystem.stage2)
        {
            source2.volume = musicVolume;
            source1.volume = 0;
        }
        else {
            source1.volume = musicVolume;
            source2.volume = 0;
        }
    }

    public void setVolume(float volume) {
        musicVolume = volume;
    }
}
