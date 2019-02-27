using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stepsCreating : MonoBehaviour {
    
    public Material boxmateriali;
	public int numberOfSteps = 9; 

	// Use this for initialization
	void Start () {
		
		for (int i=0; i < numberOfSteps; i++){
			
		
		
		GameObject newStep = GameObject.CreatePrimitive(PrimitiveType.Cube);
		
		newStep.transform.position = this.transform.position;
		newStep.transform.localScale = this.transform.lossyScale;
		newStep.transform.Rotate(Vector3.up * (i * -2f));
		newStep.transform.Translate(Vector3.forward * this.transform.lossyScale.z * i);
		newStep.transform.Translate(Vector3.up * this.transform.lossyScale.y * i);
		newStep.GetComponent<Renderer>().material = boxmateriali;

		}
	}
	
	
}
