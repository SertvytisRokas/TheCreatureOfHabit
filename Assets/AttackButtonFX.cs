using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackButtonFX : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clickClip;

    [SerializeField]
    Button button;

    

    public void ClickSound()
    {
        
        if (button.interactable == true)
        {
            source.PlayOneShot(clickClip);
        }
    }
}
