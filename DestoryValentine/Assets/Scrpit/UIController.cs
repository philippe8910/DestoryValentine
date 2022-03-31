using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scrpit.EventList;
using Project;

public class UIController : MonoBehaviour
{
    
    private UIManager uiManager;
    
    void Start()
    {
        uiManager = GetComponent<UIManager>();

        EventBus.Subscribe<OpenLevelMenuDetected>(OnOpenLevelMenuDetected);
        EventBus.Subscribe<OpenSettingMenuDetected>(OnOpenSettingMenuDetected);
        EventBus.Subscribe<OpenShopMenuDetected>(OnOpenShopMenuDetected);
        
        EventBus.Subscribe<LoseLevelDetected>(OnLoseLevelDetected);
        EventBus.Subscribe<PassLevelDetected>(OnPassLevelDetected);
    }

    private void OnPassLevelDetected(PassLevelDetected obj)
    {
        uiManager.OpenWinPanel();
    }

    private void OnLoseLevelDetected(LoseLevelDetected obj)
    {
        uiManager.OpenLosePanel();
    }


    private void OnOpenLevelMenuDetected(OpenLevelMenuDetected obj)
    {
        uiManager.OpenLevelMenu();
    }

    private void OnOpenSettingMenuDetected(OpenSettingMenuDetected obj)
    {
        uiManager.OpenSettingMenu();
    }

    private void OnOpenShopMenuDetected(OpenShopMenuDetected obj)
    {
        uiManager.OpenShopMenu();   
    }
}
