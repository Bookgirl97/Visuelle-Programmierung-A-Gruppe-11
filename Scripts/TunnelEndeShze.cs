using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TunnelEndeShze : MonoBehaviour {
	
public Text textb;

	// Use this for initialization
	void Start () {
		textb = GameObject.Find("Text").GetComponent<Text>();
		  textb.color = Color.clear; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
          
           SceneManager.LoadScene("Endszene");
		    textb.color = Color.white;
        }

    }
}
