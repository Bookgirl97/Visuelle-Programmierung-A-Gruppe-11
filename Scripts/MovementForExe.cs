using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementForExe : MonoBehaviour {

  public float moveSpeed;
      public bool moveForward;
	// Use this for initialization
	void Start () {
     moveForward = true;

	}
	
	// Update is called once per frame
	void Update () {
		
		if(moveForward){
			
		
		
		transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime);
		
		}

		   float mouseInput = Input.GetAxis("Mouse X");
		   float mouseInputt = Input.GetAxis("Mouse Y");
		   
         Vector3 lookhere = new Vector3(-mouseInputt,mouseInput,0);
         transform.Rotate(lookhere);
		 

		 
		//  Vector3 lookheree = new Vector3(mouseInputt,0,0);
        // transform.Rotate(lookheree);
		
	}
}
