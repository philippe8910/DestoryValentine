using System.Collections;
using System.Collections.Generic;
using Project;
using Scrpit.EventList;
using UnityEngine;

public class HeartEntities : MonoBehaviour
{
    [SerializeField] private List<HeartEntity> HeartEntitie = new List<HeartEntity>();
    
    // Start is called before the first frame update
    void Start()
    {
        EventBus.Subscribe<HeartbreakDetected>(OnHeartbreakDetected);
    }

    private void OnHeartbreakDetected(HeartbreakDetected obj)
    {
        bool isAllCompelte = true;
        
        foreach (var VARIABLE in HeartEntitie)
        {
            if (!VARIABLE.GetIsBreak())
            {
                isAllCompelte = false;
            }
        }

        if (isAllCompelte)
        {
            PassLevel();
        }
    }

    private void PassLevel()
    {
        EventBus.Post(new PassLevelDetected());
    }
}
