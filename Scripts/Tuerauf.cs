using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuerauf : MonoBehaviour {
	float totalRotation = 0; 
	public Transform tuer; 
    public float rotateSpeed;
	float rotationAmt;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void tuerauf(){
	
   
while(totalRotation < 90) 
{
	rotationAmt = rotateSpeed * Time.deltaTime;
    transform.Rotate(rotationAmt, 0, 0);
    totalRotation += rotationAmt; 
}

		
		
	}
	public void tuerzu(){
		tuer.transform.Rotate(0, 0, 0);
	}
}
