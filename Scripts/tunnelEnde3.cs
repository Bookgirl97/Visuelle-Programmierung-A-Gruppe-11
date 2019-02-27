using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class tunnelEnde3 : MonoBehaviour {
	
	public Material boxmaterial1;
    public Material boxmateriali;
	public Transform box;
	public Transform box1;
	public Transform box2;
	public Transform box3;
	public Transform box4;
	public Text texta;
	
	// Use this for initialization
	void Start () {
		box.GetComponent<Renderer>().material = boxmaterial1;
		box1.GetComponent<Renderer>().material = boxmaterial1;
		box2.GetComponent<Renderer>().material = boxmaterial1;
		box3.GetComponent<Renderer>().material = boxmaterial1;
		box4.GetComponent<Renderer>().material = boxmaterial1;
		 texta = GameObject.Find("Text").GetComponent<Text>();
		  texta.color = Color.clear; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
          
           SceneManager.LoadScene("Wendeltreppe");
		   box.GetComponent<Renderer>().material = boxmateriali;
		     box1.GetComponent<Renderer>().material = boxmateriali;
			   box2.GetComponent<Renderer>().material = boxmateriali;
			     box3.GetComponent<Renderer>().material = boxmateriali;
				   box4.GetComponent<Renderer>().material = boxmateriali;
				   texta.color = Color.white;
		   
        }

    }
}
