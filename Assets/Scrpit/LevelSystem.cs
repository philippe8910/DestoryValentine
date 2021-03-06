using System.Collections;
using System.Collections.Generic;
using Project;
using Scrpit.EventList;
using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    [SerializeField] private CoupleActor[] levelCoupleActors;

    [SerializeField] private int HeartBreakCount = 0;

    private GameObject currentLevel;


    void Start()
    {
        EventBus.Subscribe<ActorHeartbreakJudgement>(OnActorHeartbreakJudgement);
        EventBus.Subscribe<LevelStartDetected>(OnLevelStartDetected);
        EventBus.Subscribe<SetLevelDetected>(OnSetLevelDetected);
    }

    private void OnSetLevelDetected(SetLevelDetected obj)
    {
        
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

    public void SetLevel(string gameObject)
    {
        var level = Resources.Load<GameObject>("LevelPrefab/" + gameObject);
        var index = gameObject.Split('_');

        Debug.Log(index[1]);
        
        if (int.Parse(index[1]) >= 5)
        {
            currentLevel = Instantiate(level, level.transform.position, level.transform.rotation);
        }
        else
        {
            currentLevel = Instantiate(level, transform.position, level.transform.rotation);
        }
    }

    public void DestoryLevel()
    {
        Destroy(currentLevel);
    }
}
