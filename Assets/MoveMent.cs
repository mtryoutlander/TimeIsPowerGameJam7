using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveMent : MonoBehaviour
{
    Rigidbody2D body;
    private bool isMoving = false;

    float horizontal;
    float vertical;

    public float runSpeedX, runSpeedY;
    
    
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();        
    }

    // Update is called once per frame
    void Update()
    {
        if(!isMoving && (Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.UpArrow))){
            isMoving = true;
            vertical = Input.GetAxisRaw("Vertical");
        }
        if(!isMoving && (Input.GetKeyDown(KeyCode.S)||Input.GetKeyDown(KeyCode.DownArrow))){
            isMoving = true;
            vertical = Input.GetAxisRaw("Vertical");
        }
        if(!isMoving && (Input.GetKeyDown(KeyCode.A)||Input.GetKeyDown(KeyCode.LeftArrow))){
            isMoving = true;
            horizontal = Input.GetAxisRaw("Horizontal");

        }
        if(!isMoving && (Input.GetKeyDown(KeyCode.D)||Input.GetKeyDown(KeyCode.RightArrow))){
            isMoving = true;
            horizontal = Input.GetAxisRaw("Horizontal");
        }

        
    }

    private void FixedUpdate()
    {
        body.transform.position += new UnityEngine.Vector3(horizontal * runSpeedX, vertical * runSpeedY, 0); 
        horizontal =0;
        vertical =0;
        isMoving =false;
    }
   
}
