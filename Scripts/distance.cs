using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class distance : MonoBehaviour {
	float totalRotation = 0; 
    public Transform other;
	public float dist;
	public float distx;
	public Transform haus;
	public Transform klavier;
	public float disti;
    public float spinForce; 	
	public Transform tuer; 
	public Text textz;
    public float rotationAmt;
	public AudioClip Music;
	public AudioSource Source; 
	
	//public bool rot = false; 
	// Use this for initialization
	void Start () {
  textz = GameObject.Find("Textx").GetComponent<Text>();
        textz.color = Color.clear;					  
            Source.clip = Music;
	
        
	}
	
	// Update is called once per frame
	void Update () {
		 dist = Vector3.Distance(other.position, transform.position);
            
			if(dist<5){
				while(totalRotation < 90) 
{
	rotationAmt = spinForce * Time.deltaTime;
    tuer.transform.Rotate(rotationAmt, 0, 0);
    totalRotation += rotationAmt; 
	Source.Play();
}
		
               
				 
			}
	
					
					//tuer.transform.Rotate(spinForce * Time.deltaTime, 0, 0); 
					
			
		disti = Vector3.Distance(haus.position, transform.position);
            
			if(disti<12){              
					 
					  textz.color = Color.white;
				 
				 
			}
			

	 
			}
	
	

}


