using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunnelDrehung : MonoBehaviour {
	
	
    public Transform VrCamera;
    public float toggleAngle = 30.0f;
	public Transform tunnel; 
	public float spinForce;

	// Use this for initialization
	void Start () {
               
			
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void Sg () {
               
			  tunnel.transform.Rotate(0, 0, spinForce * Time.deltaTime);
			
        
	}
	
	public void Sgstop () {
               
			  tunnel.transform.Rotate(0, 0, 0);
			
        
	}
	
	
}
