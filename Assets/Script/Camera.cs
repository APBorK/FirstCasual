using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public static Vector3 cour;
    void Update()
    {
        Vector3 cour = UnityEngine.Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
