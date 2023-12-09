using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveFollower : MonoBehaviour
{
    public Transform target; // El objetivo al que moverse
    public float speed = 100f; // La velocidad de movimiento

    private bool move = false; // Controla si el cubo debería moverse
    void Update()
    {
        if (move)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }

    // Método para ser llamado por el botón de la UI
    public void StartMoving()
    {
        move = true;
    }
}
