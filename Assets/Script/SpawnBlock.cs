using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlock : MonoBehaviour
{
    public Transform spawn;
    public GameObject objToSpawn;

    
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 spawnPos = new Vector3(spawn.position.x,0.42f + i,spawn.position.z);
            Instantiate(objToSpawn, spawnPos, Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
}

