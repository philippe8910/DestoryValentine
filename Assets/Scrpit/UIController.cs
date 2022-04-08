using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scrpit.EventList;
using Project;

public class UIController : MonoBehaviour
{
    private UIManager uiManager;
    
    
    /*
     *  MENU INDEX
     *  1 : SHOP
     *  2 : LEVEL
     *  3 : SETTING
     */
    
    void Start()
    {
        uiManager = GetComponent<UIManager>();

        EventBus.Subscribe<OpenMenuDetected>(OnOpenMenuDetected);

        
        EventBus.Subscribe<LoseLevelDetected>(OnLoseLevelDetected);
        EventBus.Subscribe<PassLevelDetected>(OnPassLevelDetected);
    }

    private void OnOpenMenuDetected(OpenMenuDetected obj)
    {
        var menuIndex = obj.index;


        switch (menuIndex)
        {
            case 1:  //SHOP
                uiManager.OpenShopMenu();
                break;
            
            case 2: //LEVEL
                uiManager.OpenLevelMenu();
                break;
            
            case 3: //SETTING
                uiManager.OpenSettingMenu();
                break;
        }
    }

    private void OnPassLevelDetected(PassLevelDetected obj)
    {
        var StarCount = obj.StarCount;
        
        uiManager.OpenWinPanel(StarCount);
        Debug.Log("OnPassLevelDetected");
    }

    private void OnLoseLevelDetected(LoseLevelDetected obj)
    {
        uiManager.OpenLosePanel();
        Debug.Log("OnLoseLevelDetected");
    }
    
}
