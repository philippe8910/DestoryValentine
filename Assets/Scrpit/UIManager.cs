using System;
using System.Collections;
using System.Collections.Generic;
using Project;
using Scrpit.EventList;
using UnityEditor;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private SettlingMenuEntity LosePanel;

    [SerializeField] private SettlingMenuEntity WinPanel;

    [SerializeField] private MenuEntity SettingMenu;

    [SerializeField] private MenuEntity ShopMenu;

    [SerializeField] private MenuEntity LevelMenu;

    private List<MenuEntity> menuEntities = new List<MenuEntity>();

    void Start()
    {
        menuEntities.Add(ShopMenu);
        menuEntities.Add(LevelMenu);
        menuEntities.Add(SettingMenu);
    }

    public void OpenSettingMenu()
    {
        ResetAllMenu();

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
        ResetAllMenu();

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
        ResetAllMenu();
        
        if (LevelMenu.GetIsOpen())
        {
            LevelMenu.Close();
        }
        else
        {
            LevelMenu.Open();
        }
    }


    public void OpenWinPanel(int SettlingStar)
    {
        WinPanel.Open();
        WinPanel.SetSettlingStar(SettlingStar);
    }

    public void OpenLosePanel()
    {
        LosePanel.Open();
    }

    public void ResetAllMenu()
    {
        foreach (var menu in menuEntities)
        {
            if (menu.GetIsOpen())
            {
                menu.Close();
            }
        }
    }
}
