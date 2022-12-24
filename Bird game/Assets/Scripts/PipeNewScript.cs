using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PipeNewScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5;
    public float killZone = -40;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * (moveSpeed * Time.deltaTime);

        if (transform.position.x < killZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }

    }
}
