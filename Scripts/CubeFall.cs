using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFall : MonoBehaviour {
	
public float speed = 1;

	// Use this for initialization
	void Start () {
		  
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

          GetComponent<Rigidbody> ().angularVelocity = Vector3.right * Input.GetAxisRaw ("Horizontal") * speed;
		  GetComponent<Rigidbody> ().angularVelocity = Vector3.forward * -Input.GetAxisRaw ("Vertical") * speed;
		  
        }

    }
}
