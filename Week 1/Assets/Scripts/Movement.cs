using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move the player horizontally
        transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        

    }

    private void OnCollisionEnter(Collision collision)
    {
        //destroy player when in contact with object
        Destroy(gameObject);
    }
}
