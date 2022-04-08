using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettlingMenuEntity : MenuEntity
{
    [SerializeField] private GameObject[] StarImage;

    public void SetSettlingStar(int _star)
    {
        StarImage[0].SetActive(false);
        StarImage[1].SetActive(false);
        StarImage[2].SetActive(false);


        for (int i = 0 ; i < _star ; i++)
        {
            StarImage[i].SetActive(true);
        }
        
    }
}
