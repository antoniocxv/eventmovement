using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{
  


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            Movement movementScript = other.GetComponent<Movement>();
            if (movementScript != null)
            {
                movementScript.strength = true; // Activa el atributo strength
            }

            gameObject.SetActive(false);
        }
    }
}
