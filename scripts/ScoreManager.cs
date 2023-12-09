using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0; // La puntuación actual
    public int life = 100; // La puntuación actual
    public TextMeshProUGUI scoreText; // Referencia al componente de texto de la puntuación en la UI
    public TextMeshProUGUI lifeText; // Referencia al componente de texto de la puntuación en la UI

    public void IncreaseScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score; 
    }

    public void DecreaseLife(int restlife)
    {
        life = life - restlife ; 
        lifeText.text = "Health: " + life;
    }
}
