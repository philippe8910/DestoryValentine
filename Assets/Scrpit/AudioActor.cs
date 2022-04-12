using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioActor : MonoBehaviour
{
    [SerializeField] private AudioSource buttonPress;

    [SerializeField] private AudioSource boubleBreak;
    public void PlayButtonPress()
    {
        buttonPress.Play();
    }

    public void PlayBoubleBreak()
    {
        boubleBreak.Play();
    }

    
}
