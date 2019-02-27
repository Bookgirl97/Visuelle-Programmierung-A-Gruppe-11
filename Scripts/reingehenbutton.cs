using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reingehenbutton : MonoBehaviour {
    
	public float spinForce; 	
	float totalRotation = 0; 
	public Transform tuer; 
    public float rotationAmt;
	public AudioClip Music;
	public AudioSource Source; 
	// Use this for initialization
	void Start () {
		 Source.clip = Music;
	}
	public void playButton(){
		while(totalRotation < 90) 
{
	rotationAmt = spinForce * Time.deltaTime;
    tuer.transform.Rotate(rotationAmt, 0, 0);
    totalRotation += rotationAmt; 
	Source.Play();
}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
