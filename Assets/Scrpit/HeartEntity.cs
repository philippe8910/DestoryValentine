using System;
using System.Collections;
using Project;
using Scrpit.EventList;
using UnityEngine;

public class HeartEntity : MonoBehaviour
{
    [SerializeField] private CoupleActor coupleActor;

    [SerializeField] private bool isLast = false;
    
    [SerializeField] private bool isBreak = false;

    private void Start()
    {
        coupleActor = GetComponentInParent<CoupleActor>();
    }

    private void Heartbreak()
    {
        EventBus.Post(new ActorHeartbreakJudgement(isLast));
        
        coupleActor.BreakUps();
        
        gameObject.SetActive(false);
        isBreak = true;
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
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
