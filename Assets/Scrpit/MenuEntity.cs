using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuEntity : MonoBehaviour
{
   [SerializeField] private Animator animator;

   [SerializeField] private bool isOpen;

   public void Start()
   {
      animator = GetComponent<Animator>();
   }

   public void Open()
   {
      animator.Play("FadeIn");
      isOpen = true;
   }

   public void Close()
   {
      animator.Play("FadeOut");
      isOpen = false;
   }

   public void Default()
   {
      animator.Play("Defult");
      isOpen = false;
   }

   public bool GetIsOpen()
   {
      return isOpen;
   }
   
   
}
