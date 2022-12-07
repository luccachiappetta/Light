using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
   
   
   private PlayerMovement player;
   private Controls controls;
   private Vector2 moveDir;
   
   private void Awake()
   {
      controls = new Controls();
      player = GetComponent<PlayerMovement>();
   }

   private void OnEnable()
   {
      controls.Player.Enable();
   }
   
   private void OnDisable()
   {
      controls.Player.Disable();
   }

   
   private void Start()
   {
      
   }

   private void Update()
   {
      moveDir = controls.Player.Move.ReadValue<Vector2>();
      player.Move(moveDir);
      // Debug.Log(moveDir);
   }
}