using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fear : MonoBehaviour
{
    public float moveDistance = 100.0f; // La distancia a la que se moverá el obstáculo
    public float thresholdDistance = 100.0f; // La distancia a la que el obstáculo reaccionará

    private void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
            Movement playerScript = player.GetComponent<Movement>();

            if (distanceToPlayer < thresholdDistance && playerScript.strength)
            {
                Console.WriteLine("He entrado");
                Vector3 directionAwayFromPlayer = (transform.position - player.transform.position).normalized;
                directionAwayFromPlayer.y = 0;
                transform.position += directionAwayFromPlayer * moveDistance * Time.deltaTime; 
            }
        }
    }
}
