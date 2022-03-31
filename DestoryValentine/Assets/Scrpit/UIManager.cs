using System;
using System.Collections;
using System.Collections.Generic;
using Project;
using Scrpit.EventList;
using UnityEditor;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private MenuEntity LosePanel;

    [SerializeField] private MenuEntity WinPanel;

    [SerializeField] private MenuEntity SettingMenu;

    [SerializeField] private MenuEntity ShopMenu;

    [SerializeField] private MenuEntity LevelMenu;

    private List<MenuEntity> MenuEntities = new List<MenuEntity>();
    void Start()
    {
        MenuEntities.Add(LosePanel);
        MenuEntities.Add(WinPanel);
        MenuEntities.Add(SettingMenu);
        MenuEntities.Add(ShopMenu);
        MenuEntities.Add(LevelMenu);
    }

    public void OpenSettingMenu()
    {
        
    }

    public void OpenWinPanel()
    {
        
    }

    public void OpenLosePanel()
    {
        
    }

    public void OpenShopMenu()
    {
        
    }

    public void OpenLevelMenu()
    {
        
    }

    public void ResetAllMenu()
    {
        foreach (var VARIABLE in MenuEntities)
        {
            if (VARIABLE.GetIsOpen())
            {
                VARIABLE.Close();
            }
        }
    }
}
