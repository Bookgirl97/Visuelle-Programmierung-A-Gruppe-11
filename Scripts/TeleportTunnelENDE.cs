﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTunnelENDE : MonoBehaviour {

    public Transform player;
    public Transform reciever;
    public Transform reciever2;
	 	public float spinForce;
    public int count;

    private bool playerIsOverlapping = false;

    void Start()
    {
        count = 0; 
    }
    // Update is called once per frame
    void Update()
    {
        if (playerIsOverlapping)
        {
            Vector3 portalToPlayer = player.position - transform.position;
            float dotProduct = Vector3.Dot(transform.up, portalToPlayer);

            // If this is true: The player has moved across the portal
            if (dotProduct < 0f)
            {
                // Teleport him!
                float rotationDiff = -Quaternion.Angle(transform.rotation, reciever.rotation);
                rotationDiff += 180;
                player.Rotate(Vector3.up, rotationDiff);

                Vector3 positionOffset = Quaternion.Euler(0f, rotationDiff, 0f) * portalToPlayer;
                player.position = reciever.position + positionOffset;

                playerIsOverlapping = false;
            }
            if(count > 10)
            {
				
                float rotationDiff = -Quaternion.Angle(transform.rotation, reciever2.rotation);
                rotationDiff += 180;
                player.Rotate(Vector3.up, rotationDiff);

                Vector3 positionOffset = Quaternion.Euler(0f, rotationDiff, 0f) * portalToPlayer;
                player.position = reciever2.position + positionOffset;

                playerIsOverlapping = false;
				
				

            }
			
	
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerIsOverlapping = true;
            count = count + 1; 
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerIsOverlapping = false;
        }
    }
}
