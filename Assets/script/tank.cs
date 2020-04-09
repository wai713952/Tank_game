using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank : MonoBehaviour
{
    public float speed;
    public float turnspeed;
 
     void Update () 
     {

         //moves forward-backward
        if(Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(Vector3.forward * Time.deltaTime * speed,Space.Self);      //forward
        }
        if(Input.GetKey(KeyCode.DownArrow)) {
            transform.Translate(Vector3.back * Time.deltaTime * speed,Space.Self);    //backward
        }

        //rotation 
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Rotate(Vector3.up * Time.deltaTime * turnspeed);    //rotate_left
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate(Vector3.down * Time.deltaTime * turnspeed);    //rotate_left
        }
        
        
     }
}