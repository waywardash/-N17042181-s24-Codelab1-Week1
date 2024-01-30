using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float delay = 0.2f;  // Time delay between spawns
    public GameObject cube; // Prefab of the cube to be spawned
    
    
    // Start is called before the first frame update
    void Start()
    {
        // Set up repeating invocation of the "Spawn" method with the specified delay
        InvokeRepeating("Spawn", delay, delay);
    }

    void Spawn()
    {
        // Instantiate a cube at a random position the X-axis, fixed Y position of 10, and no rotation
        Instantiate(cube, new Vector3(Random.Range(-6, 6), 10, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
