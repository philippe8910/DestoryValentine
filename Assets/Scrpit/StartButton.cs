using System.Collections;
using System.Collections.Generic;
using Project;
using UnityEngine;

public class StartButton : ButtonListener
{
    public override void OnClick()
    {
        EventBus.Post(new LevelStartDetected());
    }
}
