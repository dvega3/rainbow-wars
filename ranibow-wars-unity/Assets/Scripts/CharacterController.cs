﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

	public float moveSpeed;
	public GameObject camera;
    float cameraRotX = 0f;
    public float cameraPitchMax = 70f;

    private Rigidbody rbody;

 	// Use this for initialization
 	void Start () 
 	{
  		moveSpeed = 400f;
  		rbody = GetComponent<Rigidbody>();
 	}
 
 	// Update is called once per frame
 	void Update () 
 	{
 		rbody.AddForce(-1*moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,-1*moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime);
  		//transform.Translate(-1*moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,-1*moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime); 	
 		cameraRotX -= Input.GetAxis ("Mouse X") * -5f;
        cameraRotX = Mathf.Clamp (cameraRotX, -cameraPitchMax, cameraPitchMax);
        Quaternion rot = Quaternion.Euler (0, cameraRotX, 0);
        transform.localRotation = rot;
 	}
}﻿