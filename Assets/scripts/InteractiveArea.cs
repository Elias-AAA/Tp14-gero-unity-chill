using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveArea : MonoBehaviour
{
    private int score = 0;
    public int puntajeMaximoVictoria = 5;
    
    private UIManager uiManager;
    private GameManager gameManager;

    private void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            score++;
            
            if (uiManager != null)
            {
                uiManager.UpdateScore(score);
            }

            Destroy(other.gameObject);

            if (score >= puntajeMaximoVictoria)
            {
                if (gameManager != null)
                {
                    gameManager.TerminarPartida(true);
                }
            }
        }
    }
}