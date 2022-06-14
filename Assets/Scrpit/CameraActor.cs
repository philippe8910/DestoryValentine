using System.Collections;
using System.Collections.Generic;
using Project;
using UnityEngine;

public class CameraActor : MonoBehaviour
{
    [SerializeField] private GameObject bulletPlayer;

    [SerializeField] private Vector3 resetPosition;
    
    void Start()
    {
        EventBus.Subscribe<LevelStartDetected>(OnLevelStartDetected);
        resetPosition = transform.position;
    }

    public void OnReset()
    {
        transform.position = resetPosition;
    }

    private void OnLevelStartDetected(LevelStartDetected obj)
    {
        transform.parent = bulletPlayer.transform;
        transform.localPosition = new Vector3(0, 0.1f, -0.85f);
    }
    
}
