﻿using UnityEngine;
using System.Collections;

public class BosRed_Shooter_Controller : MonoBehaviour {

    public GameObject bullet;
    public float bulletSpeed;
    

    void Update()
    {

        if (Input.GetButtonDown("Jump"))
        {
            transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
            GameObject bulletObj = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
            bulletObj.GetComponent<Rigidbody2D>().velocity = transform.right * bulletSpeed;
        }

    }
}
