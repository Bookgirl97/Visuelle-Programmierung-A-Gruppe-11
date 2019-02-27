using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeRotation : MonoBehaviour {

    public Material boxmaterial;
    public Material boxmaterial2;

    public float spinForce;

	// Use this for initialization
	void Start () {
		GetComponent<Renderer>().material = boxmaterial;
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0, spinForce * Time.deltaTime);
         
		
	}

    public void ChangeSpin()
    {
        spinForce = -spinForce; 

    }

    public void ChangeColor()
    {

        GetComponent<Renderer>().material = boxmaterial2;

    }
    public void KeepColor()
    {

        GetComponent<Renderer>().material = boxmaterial;

    }


}
