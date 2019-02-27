using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLetters : MonoBehaviour {

    public GameObject[] letters; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject obj = Instantiate (letters[Random.Range(0,25)]);
        obj.transform.position = new Vector3 (
            Random.Range(-40, 40),
            10,
            Random.Range(-40, 40)
            ); 

	}
}
