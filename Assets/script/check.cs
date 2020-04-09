using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour
{
    public void OnCollisionEnter(Collision other) 
    {
        Debug.Log("HIT");
    }
}
