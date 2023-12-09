using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveFollower : MonoBehaviour
{
    public Transform target; // El objetivo al que moverse
    public float speed = 100f; // La velocidad de movimiento

    private bool move = false; // Controla si el cubo deber�a moverse
    void Update()
    {
        if (move)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }

    // M�todo para ser llamado por el bot�n de la UI
    public void StartMoving()
    {
        move = true;
    }
}
