﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlane : MonoBehaviour,IHealth
{

    [SerializeField]
    private float speed = 1f;
    [SerializeField]
    protected GameObject explosionFX;

    private Vector3 direction;
    private float v;
    private Weapon weapon;
    private int health = 100;

    private float MaxX;
    private float MinX;
    private float MaxY;
    private float MinY;

    public int Health
    {
        get
        {
            return health;
        }
    }

    private void OnEnable()
    {
        if (InputManager.Instance)
        {
            InputManager.Instance.OnSpace += FireStart;
            InputManager.Instance.OnSpaceDown += FireOnce;
            InputManager.Instance.OnMovement += Move;
        }
    }

    private void OnDisable()
    {
        if (InputManager.Instance)
        {
            InputManager.Instance.OnSpace -= FireStart;
            InputManager.Instance.OnSpaceDown -= FireOnce;
            InputManager.Instance.OnMovement -= Move;
        }
    }

    private void Awake()
    {
        weapon = GetComponent<Weapon>();
    }

    private void Start()
    {
        MaxX = ScreenXY.MaxX;
        MinX = ScreenXY.MinX;
        MaxY = ScreenXY.MaxY;
        MinY = ScreenXY.MinY;
    }


    private void Update()
    {
        ClampFrame();
    }

    private void Move(Vector3 direction)
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    private void ClampFrame()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, MinX, MaxX),
                                     Mathf.Clamp(transform.position.y, MinY, MaxY),
                                     transform.position.z);
    }

    private void FireOnce()
    {
        weapon.FireOnce();
    }
    private void FireStart()
    {
        weapon.FireStart();
    }

    public void Damage(int _value)
    {
        if (health <= 0) return;
        health -= _value;

        if (health <= 0)
        {
            if(AppConst.IsDebugMode == false)
            DestroySelf();
        }
    }


    private void DestroySelf()
    {
        Instantiate(explosionFX, this.transform.position, explosionFX.transform.rotation);
        Destroy(this.gameObject);
        Director.Instance.PlayerDead();

    }
}
