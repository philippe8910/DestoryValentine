using System.Collections;
using System.Collections.Generic;
using Project;
using Scrpit.EventList;
using UnityEngine;

public class LevelSystem : MonoBehaviour
{

    
    void Start()
    {
        EventBus.Subscribe<ActorHeartbreakJudgement>(OnActorHeartbreakJudgement);
    }

    private void OnActorHeartbreakJudgement(ActorHeartbreakJudgement obj)
    {
        var isPass = obj.isPass;
        
        if (isPass)
        {
            PassLevel();
        }
    }

    private void PassLevel()
    {
        EventBus.Post(new PassLevelDetected());
    }
}
