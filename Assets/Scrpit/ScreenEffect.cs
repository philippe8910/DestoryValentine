using System.Collections;
using System.Collections.Generic;
using Project;
using Scrpit.EventList;
using UnityEngine;

public class ScreenEffect : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasGroup;

    [SerializeField] private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        animator = GetComponent<Animator>();
        
        EventBus.Subscribe<ChangeSceneDetected>(OnChangeSceneDetected);
    }
    

    private void OnChangeSceneDetected(ChangeSceneDetected obj)
    {
        var isOpen = obj.isOpen;

        if (isOpen)
        {
            animator.Play("ScreenEffectOpen");
        }
        else
        {
            animator.Play("ScreenEffectClose");
        }
    }

    
}

