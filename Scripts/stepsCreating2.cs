using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stepsCreating2 : MonoBehaviour {
public int numberOfSteps = 9; 
    public Material boxmateriali;
	// Use this for initialization
	void Start () {
		for (int i=0; i < numberOfSteps; i++){
			
		
		
		GameObject newStep = GameObject.CreatePrimitive(PrimitiveType.Cube);
		
		newStep.transform.position = this.transform.position;
		newStep.transform.localScale = this.transform.lossyScale;
		newStep.transform.Rotate(Vector3.up * (i * 2f));
		newStep.transform.Translate(Vector3.forward * this.transform.lossyScale.z * i);
		newStep.transform.Translate(Vector3.up * this.transform.lossyScale.y * i);
		
        newStep.GetComponent<Renderer>().material = boxmateriali;

		
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
