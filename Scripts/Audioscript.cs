using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audioscript : MonoBehaviour {
	
	public AudioClip Music;
	public AudioSource Source; 

	// Use this for initialization
	void Start () {
		
		Source.clip = Music;
		Source.Play(); 
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
	}
}
