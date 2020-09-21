using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{

    //public AudioSource source;
    //private float musicVolume = 1f;

    private void Start()
    {
        //source = GetComponent
    }



  //  public void SetVolume(float volume) {
    //    audioMixer.SetFloat("volume", volume);
    //}


    public void setFullscreen(bool isFullscreen) {
        Screen.fullScreen = isFullscreen;
    }

}
