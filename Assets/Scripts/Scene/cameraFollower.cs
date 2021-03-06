﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollower : MonoBehaviour {
    public Transform target;//what camera is following
    public float smoothing;//dampening effect
    Vector3 offset;
    float lowY;//the lowest location that the camera can go
    // Use this for initialization
    void Start () {
        offset = transform.position - target.position;
        lowY = transform.position.y;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 targetCampos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCampos, smoothing * Time.deltaTime);
		if(transform.position.y < lowY)
            transform.position = new Vector3(transform.position.x, lowY, transform.position.z);
    }
}
