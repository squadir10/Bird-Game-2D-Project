using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEditor;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float Spawnrate = 2;
    private float timer = 0;
    public float Height_Off_Set = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        Spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
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

    void Spawnpipe()
    {
        float Bottompoint = transform.position.y - Height_Off_Set;
        float Toppoint = transform.position.y + Height_Off_Set;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(Bottompoint, Toppoint), 0), transform.rotation);   
    }
}
