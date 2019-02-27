using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class outOfWendeltreppe : MonoBehaviour {

    public Text texte;

	// Use this for initialization
	void Start () {
		texte = GameObject.Find("Text").GetComponent<Text>();
		  texte.color = Color.clear; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	

	
		//  public void OnCollisionEnter(Collision gameObjectInformation)
    //{
      //  if (gameObjectInformation.gameObject.name == "FPSController")
       // {
        //  Debug.Log ("Collision Detected");
         //  SceneManager.LoadScene("tunnelscene3");
		  // texte.color = Color.white; 
		  
        //}

   // }
	public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
          
         SceneManager.LoadScene("tunnelscene3");
		   texte.color = Color.white; 
		  
        }

    }
}
