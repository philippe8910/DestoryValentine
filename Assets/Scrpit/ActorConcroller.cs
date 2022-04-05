using System;
using System.Collections;
using System.Collections.Generic;
using Project;
using Scrpit.EventList;
using UnityEngine;

public class ActorConcroller : MonoBehaviour
{
    private Actor actor;

    [SerializeField] private bool isStart;
    
    [SerializeField] private Vector3 startPos, Direction;

    // Start is called before the first frame update
    void Start()
    {
        actor = GetComponent<Actor>();
        isStart = false;
        
        EventBus.Subscribe<ActorMoveDetected>(OnActorMoveDetected);
        EventBus.Subscribe<ActorRotateDetected>(OnActorRotateDetected);
    }

    private void OnActorRotateDetected(ActorRotateDetected obj)
    {
        var _direction = obj.direction;
        actor.RotateActor(_direction);
    }

    private void OnActorMoveDetected(ActorMoveDetected obj)
    {
        var _direction = obj.direction;
        actor.MoveActor(_direction);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isStart)
        {
            SetIsStart(true);
            EventBus.Post(new LevelStartDetected());
        }
        
        if(!isStart) return;
        
        if (Input.GetMouseButtonDown(0)) startPos = Input.mousePosition;
        
        DetectedActorMove();
        DetectedActorRotate();
    }


    private void DetectedActorMove()
    {
        Direction = Input.mousePosition - startPos;
        EventBus.Post(new ActorMoveDetected(Direction));
    }
    
    private void DetectedActorRotate()
    {
        Direction = Input.mousePosition - startPos;
        EventBus.Post(new ActorRotateDetected(Direction));
    }

    private void SetIsStart(bool _isStart)
    {
        isStart = _isStart;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            EventBus.Post(new LoseLevelDetected());
        }
    }
}
