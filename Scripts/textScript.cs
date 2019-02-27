using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textScript : MonoBehaviour {

    public Text texty;

	// Use this for initialization
	void Start () {
        texty = GameObject.Find("Text").GetComponent<Text>();
		  texty.color = Color.white; 
	}
	
	// Update is called once per frame
	void Update () {

      
	}
    public void FirstColor()
    {
         
        texty.color = Color.clear;

    }
    public void GetColor()
    {
         
        texty.color = Color.white;
		

    }
}
