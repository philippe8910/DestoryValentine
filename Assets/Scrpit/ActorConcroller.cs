using System;
using System.Collections;
using System.Collections.Generic;
using Project;
using Scrpit.EventList;
using UnityEngine;

public class ActorConcroller : MonoBehaviour
{
    private Actor actor;

    [SerializeField] private float speed;

    [SerializeField] private bool isStart , isEnd;
    
    [SerializeField] private Vector3 startPos, endPos, Direction;

    // Start is called before the first frame update
    void Start()
    {
        actor = GetComponent<Actor>();
        isStart = false;
        
        EventBus.Subscribe<ActorMoveDetected>(OnActorMoveDetected);
        EventBus.Subscribe<LevelStartDetected>(OnLevelStartDetected);
        EventBus.Subscribe<ActorRotateDetected>(OnActorRotateDetected);
        
        EventBus.Subscribe<PassLevelDetected>(OnPassLevelDetected);
        EventBus.Subscribe<LoseLevelDetected>(OnLoseLevelDetected);
    }

    private void OnLoseLevelDetected(LoseLevelDetected obj)
    {
        actor.ThrowBullet();
    }

    private void OnPassLevelDetected(PassLevelDetected obj)
    {
        isEnd = true;
        SetIsStart(false);
    }

    private void OnLevelStartDetected(LevelStartDetected obj)
    {
        isEnd = false;
        
        if (!isStart)
        {
            SetIsStart(true);
        }
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
        if(!isStart) return;
        
        transform.Translate(0,0,speed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
            endPos = startPos;
        }

        if (Input.GetMouseButton(0))
        {
            endPos = Input.mousePosition;
        }
        

        DetectedActorMove();
        DetectedActorRotate();
        
        
    }


    private void DetectedActorMove()
    {
        Direction = (endPos - startPos) * 0.1f;
        EventBus.Post(new ActorMoveDetected(Direction));
    }
    
    private void DetectedActorRotate()
    {
        Direction = (endPos - startPos) * 0.1f;
        EventBus.Post(new ActorRotateDetected(Direction));
    }

    private void SetIsStart(bool _isStart)
    {
        isStart = _isStart;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Finish") && !isEnd)
        {
            EventBus.Post(new LoseLevelDetected());
        }
    }

    public void OnResetPosition()
    {
        actor.ResetPosition();
        isStart = false;
    }
}
