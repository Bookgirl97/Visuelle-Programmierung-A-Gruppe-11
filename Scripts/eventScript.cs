using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventScript : MonoBehaviour
{

    public Transform newPos;

    public void OnTriggerEnter2(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = newPos.position;
        }
    }
}



