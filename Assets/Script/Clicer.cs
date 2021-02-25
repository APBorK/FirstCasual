using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Clicer : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (Input.GetMouseButton(1))
        {
            
            transform.position = Vector3.MoveTowards(transform.position, Input.mousePosition,
                Time.deltaTime * 100f);
        }
        
    }

    void Start()
    {
        
    }
    
    void Update()
    {
       
    }
}
