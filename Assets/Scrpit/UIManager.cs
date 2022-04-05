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

    void Start()
    {
       
    }

    public void OpenSettingMenu()
    {
        if (SettingMenu.GetIsOpen())
        {
            SettingMenu.Close();
        }
        else
        {
            SettingMenu.Open();
        }
    }

    public void OpenShopMenu()
    {
        if (ShopMenu.GetIsOpen())
        {
            ShopMenu.Close();
        }
        else
        {
            ShopMenu.Open();
        }
    }

    public void OpenLevelMenu()
    {
        if (LevelMenu.GetIsOpen())
        {
            LevelMenu.Close();
        }
        else
        {
            LevelMenu.Open();
        }
    }
    
    
    public void OpenWinPanel()
    {
        WinPanel.Open();
        ResetAllMenu();
    }

    public void OpenLosePanel()
    {
        LosePanel.Open();
        ResetAllMenu();
    }

    public void ResetAllMenu()
    {
        
    }
}
