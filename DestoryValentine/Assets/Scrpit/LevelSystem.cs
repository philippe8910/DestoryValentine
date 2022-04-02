using System.Collections;
using System.Collections.Generic;
using Project;
using Scrpit.EventList;
using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    [SerializeField] private List<HeartEntity> HeartEntities = new List<HeartEntity>();
    
    // Start is called before the first frame update
    void Start()
    {
        EventBus.Subscribe<HeartbreakDetected>(OnHeartbreakDetected);
    }

    private void OnHeartbreakDetected(HeartbreakDetected obj)
    {
        
    }

    private void PassLevel()
    {
        EventBus.Post(new PassLevelDetected());
    }
}
