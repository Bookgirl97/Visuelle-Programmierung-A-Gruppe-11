using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class totunnel2 : MonoBehaviour {
	
public Text textd;

	// Use this for initialization
	void Start () {
		textd = GameObject.Find("Text").GetComponent<Text>();
		  textd.color = Color.clear; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
          
           SceneManager.LoadScene("tunnelscene2");
		  textd.color = Color.white; 
        }

    }
}
