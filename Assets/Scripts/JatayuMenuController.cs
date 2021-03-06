﻿/*
 * Young Indian Culture Group Inc. 5013(c)
 * 
 * Copyright (c) 2017
 * 
 * Author       :   Pranav S. Krishnamurthy
 * 
 * Project      :   Jatayu's Journey
 * 
 * File Name    :   JatayuMenuController.cs
 * 
 * Date Created :   6th July 2017
 * 
 * Purpose      :   To be able to animate Jatayu from the onset of the game
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JatayuMenuController : MonoBehaviour
{

    private Animator anim; // Having the animation reference
    private Rigidbody2D rbJatayuMenu; // Creating the reference to the Rigidbody2D component

    // Use this for initialization
    void Start()
    {
        // Getting the reference to the component for the animator controller
        anim = GetComponent<Animator>();

        // Get and store the Rigidbody2D reference
        rbJatayuMenu = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetTrigger("Flap");

        rbJatayuMenu.velocity = Vector2.zero;
    }
}