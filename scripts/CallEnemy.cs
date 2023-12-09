using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallEnemy : MonoBehaviour
{
    public Transform player; // Referencia al jugador
    public float speed = 5f; // Velocidad a la que el objeto perseguirá al jugador
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Asegúrate de que tu jugador tenga el tag "Player"
        {
            FollowPlayer follow= FindObjectOfType<FollowPlayer>();
            if (follow != null)
            {
                follow.callEnemy(); // pone a true al buscador
            }


        }

    }
}
