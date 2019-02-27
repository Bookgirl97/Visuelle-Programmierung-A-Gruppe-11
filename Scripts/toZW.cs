using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class toZW : MonoBehaviour {

public Text textc;

	// Use this for initialization
	void Start () {
		textc = GameObject.Find("Text").GetComponent<Text>();
		  textc.color = Color.clear; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
          
           SceneManager.LoadScene("Wendeltreppe");
		   textc.color = Color.white; 
		  
        }

    }
}
