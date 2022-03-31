using System;
using System.Collections;
using Project;
using Scrpit.EventList;
using UnityEngine;

public class HeartEntity : MonoBehaviour
{
    [SerializeField] private bool isBreak;
    
    private void Heartbreak()
    {
        EventBus.Post(new HeartbreakDetected());
        isBreak = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            Debug.Log("owo");
        
            if (other.CompareTag("Bullet"))
            {
                Heartbreak();    
            }
        }
    }
    public bool GetIsBreak()
    {
        return isBreak;
    }
    
    
}
