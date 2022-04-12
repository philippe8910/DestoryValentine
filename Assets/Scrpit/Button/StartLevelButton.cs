using System.Collections;
using System.Collections.Generic;
using Project;
using UnityEngine;

public class StartLevelButton : ButtonListener
{
    public override void OnClick()
    {
        EventBus.Post(new LevelStartDetected());
        
        gameObject.SetActive(false);
    }
}
