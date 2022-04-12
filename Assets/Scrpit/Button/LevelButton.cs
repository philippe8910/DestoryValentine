using System.Collections;
using System.Collections.Generic;
using Project;
using Scrpit.EventList;
using UnityEngine;

public class LevelButton : ButtonListener
{
    public override void OnClick()
    {
        EventBus.Post(new OpenMenuDetected(2));
    }
}
