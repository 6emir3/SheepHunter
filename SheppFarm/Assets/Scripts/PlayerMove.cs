using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMove : MonoBehaviour
{

    public Rigidbody2D rb;
    public Vector2 moveVector;

    public float speed = 2f;

    public Animator anim;
    public SpriteRenderer sr;

    public bool faceRight = true;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        anim.SetInteger("skin", PlayerPrefs.GetInt("skin"));
    }

    
    void Update()
    {
        walk();
        Reflect();
        Jump();
        CheckinGround();
        
    }

    void walk()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        anim.SetFloat("moveX", Mathf.Abs(moveVector.x));
        rb.velocity = new Vector2(moveVector.x * speed, rb.velocity.y);
    }

    void Reflect()
    {
        if ((moveVector.x > 0 && !faceRight) || (moveVector.x < 0 && faceRight))
        {
            transform.localScale *= new Vector2(-1, 1);
            faceRight = !faceRight;
        }
    }


    public float jumpForce = 350f;
    
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onGround) 
        {
            rb.AddForce(Vector2.up * jumpForce);
        }
    }

    public bool onGround;
    public Transform GroundCheck;
    public float checkRadius = 0.5f;
    public LayerMask Ground;
  

    void CheckinGround()
    {
        onGround = Physics2D.OverlapCircle(GroundCheck.position, checkRadius, Ground);
    }

   

}
