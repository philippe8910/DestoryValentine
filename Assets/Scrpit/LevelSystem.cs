using System.Collections;
using System.Collections.Generic;
using Project;
using Scrpit.EventList;
using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    [SerializeField] private CoupleActor[] levelCoupleActors;

    [SerializeField] private int HeartBreakCount = 0;


    void Start()
    {
        EventBus.Subscribe<ActorHeartbreakJudgement>(OnActorHeartbreakJudgement);
        EventBus.Subscribe<LevelStartDetected>(OnLevelStartDetected);
    }

    private void OnLevelStartDetected(LevelStartDetected obj)
    {
        ReloadLevelCoupleActor();
    }

    private void OnActorHeartbreakJudgement(ActorHeartbreakJudgement obj)
    {
        var isPass = obj.isPass;
        HeartBreakCount++;
        
        if (isPass)
        {
            PassLevel();
        }
    }

    private void ReloadLevelCoupleActor()
    {
        levelCoupleActors = GetComponentsInChildren<CoupleActor>();
        HeartBreakCount = 0;
    }

    private void PassLevel()
    {
        if (HeartBreakCount >= levelCoupleActors.Length)
        {
            EventBus.Post(new PassLevelDetected(2));
        }
        else
        {
            EventBus.Post(new PassLevelDetected(1));
        }
        
    }
}
