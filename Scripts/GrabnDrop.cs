using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabnDrop : MonoBehaviour
{
   // public TextMesh answer;
    GameObject grabbedObject;
    float grabbedObjectSize;
    float force = 100f;


    //CHECK WHICH OBJECT IS IN FRONT OF THE CAMERA LINE
    GameObject GetObjectInFrontOfPlayer(float range)
    {

        Vector3 position = gameObject.transform.position;
        RaycastHit raycastHit;
        Vector3 target = position + Camera.main.transform.forward * range;

        if (Physics.Linecast(position, target, out raycastHit))
        {
            Debug.Log("Grabbed " + raycastHit.collider.name);

            return raycastHit.collider.gameObject;
        }
        return null;

    }

    //TRY TO GRAB OBJECT THAT IS IN FRONT OF CAMERA AS ARGUMENT PASSED
    void TryGrabObject(GameObject grabObject)
    {
        if (grabObject == null || !CanGrab(grabObject))
            return;
        grabbedObject = grabObject;
        grabbedObjectSize = grabObject.GetComponent<Renderer>().bounds.size.magnitude;
        grabObject.GetComponent<Rigidbody>().freezeRotation = true;
       // answer.text += grabObject.name.Substring(0, 1);



    }
    //IF IT HAS RIGIDBODY IT CAN BE GRABBED
    bool CanGrab(GameObject canidate)
    {
        return canidate.GetComponent<Rigidbody>() != null;
    }

    //DROP OBJECT
    void DropObject()
    {
        if (grabbedObject == null)
            return;


        if (grabbedObject.GetComponent<Rigidbody>() != null)
        {

            grabbedObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            //grabbedObject.GetComponent<Rigidbody> ().AddForce (transform.forward * force);
            Debug.Log("Force " + force);
            force = 100;
        }
        grabbedObject = null;
    }

    void Update()
    {



        //Check if I have grabbed anthing, if yes, add force
        if (gameObject != null)
            force++;

        //Check if user pressed the mouse button
        if (Input.GetMouseButtonDown(0))
        {
            //If nothing has been grabbed, then try to grab
            if (grabbedObject == null)
                //GRAB THE OBJECT WHICH IS IN FRONT OF CAMERA
                TryGrabObject(GetObjectInFrontOfPlayer(15));

        }

        //If mouse button has been released, then drop it
        if (Input.GetMouseButtonUp(0))
            DropObject();

        //If something has been grabbed, then move it with the camera
        if (grabbedObject != null)
        {
            Vector3 newPosition = gameObject.transform.position + Camera.main.transform.forward * grabbedObjectSize;
            grabbedObject.transform.position = newPosition;
        }

    }
}

