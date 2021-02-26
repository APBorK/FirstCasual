using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointInfo : MonoBehaviour
{
    public static Transform wayPoint;
   
    

    private void Start()
    {
    }

    public void Update()
    {
        if (wayPoint == false)
        {
            FindPlayer();
        }
        
    }

    public static void FindPlayer() 
    {
        wayPoint = GameObject.FindGameObjectWithTag("Point").transform;
        
    }

 }
