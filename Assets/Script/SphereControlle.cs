using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControlle : MonoBehaviour
{
    public Vector3 spherePosition;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spherePosition = transform.position;
    }
}
