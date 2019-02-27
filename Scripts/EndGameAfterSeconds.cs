using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameAfterSeconds : MonoBehaviour {
	
	private float timer = 20f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
	
		
		if(timer <= 0){
			SceneManager.LoadScene(0);
		}
		
	}
	
//IEnumerator MyMethod(){
	
	//yield return new WaitForSeconds(5);
	//  Debug.Log ("Collision Detected");
	//SceneManager.LoadScene(0);
	//yield return null; 
//}
}

