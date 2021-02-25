
using UnityEngine;


public class MoveSphere : MonoBehaviour
{
    public int speed = 3;

    private Vector3 _lastPos;

    private void Start()
    {
        _lastPos = transform.position;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
           
        }
        
        _lastPos = transform.position;
        
    }
}