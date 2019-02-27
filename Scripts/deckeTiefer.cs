using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deckeTiefer : MonoBehaviour {
	
	
    public Transform VrCamera;
    public float toggleAngle = 30.0f;
	public Transform decke; 
	public float spinForce;

	// Use this for initialization
	void Start () {
               
			
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void Sg () {
               
decke.transform.Rotate(0, 0, spinForce * Time.deltaTime);
			
        
	}
	
	public void Sgstop () {
               
			 decke.transform.Rotate(0, 0, 0);
			
        
	}
	
	
}
