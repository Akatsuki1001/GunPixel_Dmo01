﻿using UnityEngine;
using System.Collections;

public class DestroyBullet : MonoBehaviour {
    public float aliveTime;
    // Use this for initialization
    void Start () {

        Destroy(gameObject, aliveTime);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
