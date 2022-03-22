using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerController : MonoBehaviour
{
    public float speed = 3.0f;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(0.0f, +Input.GetAxis("Horizontal") * speed, 0.0f);
    }
}
