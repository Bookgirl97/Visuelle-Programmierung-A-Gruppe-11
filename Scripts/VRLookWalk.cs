﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLookWalk : MonoBehaviour {

    public Transform VrCamera;
    public float toggleAngle = 30.0f;
    public float speed = 3.0f;
    public bool moveForward;
    private CharacterController cc; 

	// Use this for initialization
	void Start () {

        cc = GetComponent<CharacterController>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(VrCamera.eulerAngles.x >= toggleAngle && VrCamera.eulerAngles.x < 90.0f)
        {
            moveForward = false;

        }

        else
        {
            moveForward = true; 
        }

        if (moveForward)
        {
            Vector3 forward = VrCamera.TransformDirection(Vector3.forward);

            cc.SimpleMove(forward * speed);
        }
	}
}
