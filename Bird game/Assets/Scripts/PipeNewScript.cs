using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

// this script programs the animation of the pipe game object while also deleting the game object so that 
// there is no overflow of unused pipe game objects that take up the ram and make the game slow. 
public class PipeNewScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5; //move pipes at a speed of 5
    public float killZone = -40; // pipes get deleted at position -40 when it is off screen and unused

    // Update is called once per frame
    void Update()
    {
        //ensures that the animation speed for the pipes runs smoothly based off the computer the player is using
        transform.position += Vector3.left * (moveSpeed * Time.deltaTime); 
        
        //when the pipe reaches the killzone, destroy the game object
        if (transform.position.x < killZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }

    }
}
