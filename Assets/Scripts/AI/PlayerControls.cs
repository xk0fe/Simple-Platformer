﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : Move
{
    public Transform groundCheck;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        RunningFunc();
    }

    void RunningFunc()
    {
        if (SceneBoss.ScreenTap >= 1)
        {
            MoveRight(); //Move.cs
        }
    }

    public void JumpFunc()
    {
        if(SceneBoss.ScreenTap == 0) //player making a first tap
        {
            SceneBoss.ScreenTap++;
            JumpHigh(); //Move.cs
        }
        else if (onGround && SceneBoss.ScreenTap >= 1) //all other taps
        {
            SceneBoss.ScreenTap++;
            JumpHigh(); //Move.cs
        }
    }


    void OnTriggerEnter2D(Collider2D collision) //every star has it own tag because is it easier to use individual tags instead of a proper code in a small game
    {
        if (collision.gameObject.name == "ColStar1")
        {
            SceneBoss.StarCollected1 = 1;
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.name == "ColStar2")
        {
            SceneBoss.StarCollected2 = 1;
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.name == "ColStar3")
        {
            SceneBoss.StarCollected3 = 1;
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "DeathTag")
        {
            isDead = true;
            StopMovement();
        }
    }
}