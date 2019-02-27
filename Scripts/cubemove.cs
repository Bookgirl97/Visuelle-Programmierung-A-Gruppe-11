using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubemove : MonoBehaviour {
 public Transform destination;
 public Transform book;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void bla()
    {
        
           book.transform.position = destination.position;
           
        

    }

}
