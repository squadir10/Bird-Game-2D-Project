using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script programs the function and movement of the bird game object 
public class Bird : MonoBehaviour
{
    public Rigidbody2D myRigidbody2D;
    public float flapStrength;
    public LogicManager logic;
    public bool bird_status = true;
    
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // when spacebar is hit, make the bird fly 
        if (Input.GetKeyDown(KeyCode.Space) && bird_status)
        {
            myRigidbody2D.velocity = Vector2.up * flapStrength; //bird flies up on y-axis by a force of 10 
        }
        // changes the rotation of the bird when it comes down for a more appealing affect.
        transform.eulerAngles = new Vector3(0, 0, myRigidbody2D.velocity.y * 2f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        bird_status = false; 
    }
}


