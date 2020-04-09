using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public GameObject bullet;
    public float bulletspeed;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GameObject instBullet = Instantiate(bullet,transform.position,Quaternion.identity)
            as GameObject;
            Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();
            instBulletRigidbody.AddForce(transform.forward * bulletspeed);
            Destroy(instBullet, 5);
        }
    }
}