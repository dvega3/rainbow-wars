using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

	public float moveSpeed;

 	// Use this for initialization
 	void Start () 
 	{
  		moveSpeed = 6f;
 	}
 
 	// Update is called once per frame
 	void Update () 
 	{
  		transform.Translate(-1*moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,-1*moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime); 
 	}
}﻿