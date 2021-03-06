﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;

    public bool IsDead;

    public void MoveRight()
    {
        rb.velocity = new Vector2(4, rb.velocity.y);
    }

    public void Update()
    {
        animator.SetBool("Dead", IsDead);
        animator.SetFloat("Speed", rb.velocity.x);
    }

    public void MoveLeft()
    {
        if (IsDead == false)
        {
            if (LevelManager.ScreenTap >= 1) //enemies starting to move only if player tapped
            {
                rb.velocity = new Vector2(-3, rb.velocity.y);
            }
            else
            {
                Debug.Log("none");
            }
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }

    public void MoveLeftSlow()
    {
        if (IsDead == false)
        {
            if (LevelManager.ScreenTap >= 1) //enemies starting to move only if player tapped
            {
                rb.velocity = new Vector2(-2, rb.velocity.y);
            }
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }
    
    public void JumpHigh() //called High so there is no confusion with JumpFunc();
    {
        if(IsDead == true)
        {
            //
        }
        else
        {
            rb.velocity = new Vector2(rb.velocity.x, 12);
        }
    }

    public void StopMovement() //no longer a StopMovement function, should be renamed
    {
        rb.constraints = RigidbodyConstraints2D.FreezePositionX;
    }

    public void DisableGameObject() //disabling gameobject
    {
        this.gameObject.SetActive(false);
    }
}
