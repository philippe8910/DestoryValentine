using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Project;
using Scrpit.EventList;
using UnityEngine;

public class StartGameButton : ButtonListener
{
    [SerializeField] private RectTransform mainMenu;
    

    public override async void OnClick()
    {
        //TODO 
        EventBus.Post(new ChangeSceneDetected(true));
        EventBus.Post(new AudioPlayDetected(0));
        
        await Task.Delay(2000);
        
        mainMenu.gameObject.SetActive(false);
        
        EventBus.Post(new ChangeSceneDetected(false));
    }
}
