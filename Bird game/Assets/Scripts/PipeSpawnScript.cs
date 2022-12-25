using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEditor;
using UnityEngine;

//this script is in charge of the spawn rate of the pipes
public class PipeSpawnScript : MonoBehaviour
{
    //variables
    public GameObject pipe;
    public float Spawnrate = 2; //spawnrate as to when the pipes should spawn 
    private float timer = 0; //adds and restarts. does not change manually 
    public float Height_Off_Set = 5; //when the pipes should generate randomly based off of height 
    
    // Start is called before the first frame update
    void Start()
    {
        Spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        // if the timer is less than the spawn rate then count until 2, once the timer reaches 2, spawn the pipe object
        // and then restart the timer to 0 against and repeat
        if (timer < Spawnrate)
        {
            timer += Time.deltaTime;
            
        }
        else
        {
            Spawnpipe();
            timer = 0;
        }
        

    }

    // spawn the pipes randomly, based off of the height from bottom to top so that there are varying 
    //heights 
    void Spawnpipe()
    {
        
        float Bottompoint = transform.position.y - Height_Off_Set;
        float Toppoint = transform.position.y + Height_Off_Set;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(Bottompoint, Toppoint), 0), transform.rotation);   
    }
}
