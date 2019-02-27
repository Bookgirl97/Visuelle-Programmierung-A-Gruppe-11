using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{

    public Transform VrCamera;
    public float toggleAngle = 30.0f;
    public float speed = 3.0f;
    public bool moveForward;
    private CharacterController cc;
	public Transform player; 
    public float spinForce;
  

	
    void Start()
    {

        cc = GetComponent<CharacterController>();

    }
    // Update is called once per frame
    void Update()
    {
        if (VrCamera.eulerAngles.x >= toggleAngle && VrCamera.eulerAngles.x < 90.0f)
        {
            moveForward = false;
			
			
		

        }
	
		
		//if (VrCamera.eulerAngles.x >= toggleAngle && VrCamera.eulerAngles.x < 90.0f)
        //{
        //    moveForward = false;
			
			  //Vector3 rot = transform.rotation.eulerAngles;
             // rot = new Vector3(rot.x,rot.y,rot.z+180);
             // tunnel.transform.rotation = Quaternion.Euler(rot);
			 // player.transform.position = destination.position;
		

//        }
		

        else
        {
            moveForward = true;
			
        }
        if (Input.GetButton("Fire1") && moveForward == true)

        {
            Vector3 forward = VrCamera.TransformDirection(Vector3.forward);

            cc.SimpleMove(forward * speed);
			


        }

    }
}

/*  public int playerSpeed;


  // Update is called once per frame
  void Update()
  {
      if (Input.GetButton("Fire1"))
      {
          transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;


      }

  }*/


