using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelActor : MonoBehaviour
{
    
    void Start()
    {
        
    }

    public void SetLevel(string index)
    {
        var levelObj = Resources.Load(index);
        var levelPrefab = (GameObject) levelObj;

    }

   
}
