using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private PlayerMovement _player;
    
    //Components
    [SerializeField] private Animator _animation;
    private Rigidbody _rigidbody;

    //Animator Parameters
    private static readonly int XVelocity = Animator.StringToHash("xVelocity");

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    
    private void Update()
    {
       _animation.SetFloat(XVelocity, _rigidbody.velocity.magnitude);
    }
    
}
