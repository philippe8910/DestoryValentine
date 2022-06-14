using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMenuLerp : MonoBehaviour
{

    [SerializeField] private List<Transform> button = new List<Transform>();
    [SerializeField] private List<Transform> buttonPos = new List<Transform>();

    [SerializeField] private int Index;

    // Update is called once per frame
    void Update()
    {
        switch (Index)
        {
            case 0:
                button[0].position = Vector3.Lerp(button[0].position , buttonPos[1].position , 0.1f);
                button[1].position = Vector3.Lerp(button[1].position , buttonPos[1].position , 0.1f);
                button[0].position = Vector3.Lerp(button[0].position , buttonPos[1].position , 0.1f);
                break;
        }
    }
}
