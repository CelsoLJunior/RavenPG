﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour {

	public GameObject player;
	public VirtualJoystick joystick;
	public float moveSpeed = 1;
	
	void Start(){
	}
	// Update is called once per frame
	void Update () {
		Move();
	}

	private void Move(){
		player.transform.position += PoolInput() * (moveSpeed / 2);
	}

	private Vector3 PoolInput(){
		Vector3 dir = Vector3.zero;

		//dir.x = Input.GetAxis("Horizontal");
		//dir.z = Input.GetAxis("Vertical");

		dir.x = joystick.Horizontal();
		dir.z = joystick.Vertical();

		if (dir.magnitude > 1) 
			dir.Normalize();

		return dir;
	}
}
