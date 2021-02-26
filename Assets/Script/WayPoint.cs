using System.Collections;
using UnityEngine;

public class WayPoint : MonoBehaviour {
       
  
    public GameObject prefab;
    Ray ray;
    RaycastHit hit;   
    
    void Update () {
               
        ray=Camera.main.ScreenPointToRay(Input.mousePosition);
               
        if(Physics.Raycast(ray,out hit))
        {
                       
            if(Input.GetMouseButtonDown(0))
            {
                GameObject obj=Instantiate(prefab,new Vector3(hit.point.x,0.42F,hit.point.z), Quaternion.identity) as GameObject;
                               
            }
                       
        }
               
               
               
    }
}