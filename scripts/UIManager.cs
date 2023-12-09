using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Movement playerMovement; // Referencia al script de movimiento del jugador
    public Button speedToggleButton; // Referencia al bot�n de velocidad
    public TextMeshProUGUI speedButtonText; // Referencia al texto del bot�n

    private Color turboColor = Color.cyan; // Color para el modo turbo
    private Color normalColor = Color.white; // Color para el modo normal

    public void ToggleSpeed()
    {
        if (playerMovement.speed == 200)
        {
            playerMovement.speed = 600; // Establecer velocidad turbo
            speedButtonText.text = "Normal"; // Cambiar texto del bot�n
            speedToggleButton.GetComponent<Image>().color = turboColor; // Cambiar color del bot�n
        }
        else if (playerMovement.speed == 600)
        {
            playerMovement.speed = 200; // Establecer velocidad normal
            speedButtonText.text = "Turbo"; // Cambiar texto del bot�n
            speedToggleButton.GetComponent<Image>().color = normalColor; // Cambiar color del bot�n
        }
    }
}
