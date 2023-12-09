using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Aseg�rate de que tu jugador tenga el tag "Player"
        {
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.IncreaseScore(1); // Aumenta la puntuaci�n en 1
            }

            Destroy(gameObject); // Opcional: Destruye la moneda despu�s de ser recolectada
        }
    }
}
