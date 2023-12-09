using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // Referencia al jugador
    public float speed = 100f; // Velocidad a la que el objeto perseguirá al jugador
    public Boolean move = false;

    void Update()
    {
        if (move)
        {
            if (player != null)
            {
                Vector3 direction = (player.position - transform.position).normalized; // Dirección hacia el jugador
                transform.position += direction * speed * Time.deltaTime; // Mueve el objeto hacia el jugador
            }
        }
        
    }

    public void callEnemy()
    {
        move = true;
    }
}
