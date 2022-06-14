using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoupleActor : MonoBehaviour
{
    [SerializeField] private Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }


    public void BreakUps()
    {
        //animator.Play("BreakUp");
    }

}
