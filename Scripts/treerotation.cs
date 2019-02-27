using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class treerotation : MonoBehaviour {
	
public float spinForce;
public Transform tree; 
public Transform tree1;
public Transform tree2; 
public Transform tree3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		tree.transform.Rotate(0, spinForce * Time.deltaTime, 0);
		tree1.transform.Rotate(0, spinForce * Time.deltaTime, 0);
		tree2.transform.Rotate(0, spinForce * Time.deltaTime, 0);
		tree3.transform.Rotate(0, spinForce * Time.deltaTime, 0);
	}
}
