using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pingpong : MonoBehaviour
{

    public float x_pos,y_pos,z_pos;
    public bool x,y,z;
    public float distance;
    public float speed;
    
    void Start() 
    {
        transform.position.Set(x_pos,y_pos,z_pos);  
    }
    void Update()
    {
        
        if (x==true)
        {
            transform.position = new Vector3(Mathf.PingPong(Time.time * speed,distance),
            transform.position.y, 
            transform.position.z);
        }
        if (y==true)
        {
            transform.position = new Vector3(transform.position.x,
            Mathf.PingPong(Time.time * speed,distance), 
            transform.position.z);
        }
        if (z==true)
        {
            transform.position = new Vector3(transform.position.x,
            transform.position.y,
            Mathf.PingPong(Time.time * speed,distance));
        }
        

        /*
        transform.position = new Vector3(Mathf.PingPong(Time.time,distance),
            transform.position.y, 
            transform.position.z);
        */
    }
}