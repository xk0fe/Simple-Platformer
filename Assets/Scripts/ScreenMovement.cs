﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject StartMenu, SecondMenuCollider;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Leaderboard")
        {
            //
        }
    }

    public void MoveToSettings()
    {
        StartMenu.GetComponent<BoxCollider2D>().enabled = false;
        rb.velocity = new Vector2(1800, rb.velocity.y);   
    }

    public void MoveToMain()
    {
        SecondMenuCollider.GetComponent<BoxCollider2D>().enabled = true;
        rb.velocity = new Vector2(-1800, rb.velocity.y);
    }

    public void MoveToMainFromLvlSelection()
    {
        StartMenu.GetComponent<BoxCollider2D>().enabled = true;
        rb.velocity = new Vector2(1800, rb.velocity.y);
    }

    public void MoveToLvlSelection()
    {
        SecondMenuCollider.GetComponent<BoxCollider2D>().enabled = false;
        rb.velocity = new Vector2(-1800, rb.velocity.y);
    }

    public void MoveScreenToLeaderboard()
    {
        rb.velocity = new Vector2(rb.velocity.x, -1800);
    }

    public void MoveScreenToMainFromLeaderboard()
    {
        rb.velocity = new Vector2(rb.velocity.x, 1800);
    }
}