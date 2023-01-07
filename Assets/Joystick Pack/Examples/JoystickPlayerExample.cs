﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public DynamicJoystick variableJoystick;
    public Rigidbody rb;

    public void FixedUpdate()
    {
        Vector3 direction = -(Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal);
        transform.position+=(direction * speed * Time.fixedDeltaTime);
       // rb.velocity=direction*speed*Time.fixedDeltaTime;
    }
}