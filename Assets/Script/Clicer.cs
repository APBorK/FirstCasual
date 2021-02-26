using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Clicer : MonoBehaviour
{
    private float speed = 10;

    void Start()
    {
        
    }
    
    void Update()
    {
        
        
        if (WayPointInfo.wayPoint == true)
        {
            transform.LookAt(WayPointInfo.wayPoint.transform);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        
        
        
        
    }
    
    private void OnTriggerEnter(Collider spawn)
    {
        
        if (spawn.gameObject.CompareTag("Point"))
        {
            Destroy(spawn.gameObject);
        }
        if (spawn.gameObject.CompareTag("Cube"))
        {
            Destroy(spawn.gameObject);
        }
    }
   
   
}
