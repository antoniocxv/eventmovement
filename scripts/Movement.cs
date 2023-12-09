using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f; // Velocidad del jugador
    public Boolean strength = false;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Obtenemos el componente Rigidbody
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // Movimiento horizontal (A/D o flechas izquierda/derecha)
        float moveVertical = Input.GetAxis("Vertical"); // Movimiento vertical (W/S o flechas arriba/abajo)

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); // Crear vector de movimiento

        rb.velocity = movement * speed; // Aplicar movimiento
    }
}

