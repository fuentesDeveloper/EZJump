﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPref;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            shoot();
        }
        
    }

    void shoot()
    {
        Instantiate(bulletPref, firePoint.position, firePoint.rotation);
    }
}
