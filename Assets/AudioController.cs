using System.Collections;
using System.Collections.Generic;
using Project;
using Scrpit.EventList;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    private AudioActor audioActor;
    void Start()
    {
        audioActor = GetComponent<AudioActor>();
        
        EventBus.Subscribe<AudioPlayDetected>(OnAudioPlayDetected);
    }
    
    

    private void OnAudioPlayDetected(AudioPlayDetected obj)
    { 
        var index = obj.index;

        switch (index)
        {
            case 0: //button press
                audioActor.PlayButtonPress();
                break;
            
            case 1: //bouble break
                audioActor.PlayBoubleBreak();
                break;
        }
    }
}
