using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class klavieraudio : MonoBehaviour {
public AudioClip Music1;
	public AudioSource Source1; 
	// Use this for initialization
	void Start () {
			 
			Source1.clip = Music1;
	}
	
	// Update is called once per frame
	void Update () {
			
		
	}
	public void playit(){
	Source1.Play(); 
	}
	
	public void stopit(){
		Source1.Stop(); 
	}
	
	public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
          
           	Source1.Play(); 
		  
        }

    }
}
