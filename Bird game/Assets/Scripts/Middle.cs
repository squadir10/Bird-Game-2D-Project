using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

//the middle script adds an invisible collision to the pipes in the middle so every time the bird
//goes through the pipe, the game can keep track of the score

public class middle : MonoBehaviour
{
    // tag made for the logic manager
    public LogicManager logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>(); // uses the logic tag 
        //in reference to the Logicmanager.cs script

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //when the bird passes through the middle collider, add one.
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.layer == 3)
        {
            logic.add_score(1);
            Debug.Log("Bird scored");
        }
        
    }
}
