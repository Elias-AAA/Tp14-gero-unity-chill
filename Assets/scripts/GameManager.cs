using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timer = 60f;
    private UIManager uiManager;
    private bool juegoTerminado = false;

    private void Awake()
    {
        Time.timeScale = 1f;
    }

    private void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    private void Update()
    {
        if (juegoTerminado)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            return;
        }

        if (timer > 0)
        {
            timer -= Time.deltaTime;
            if (uiManager != null)
            {
                uiManager.UpdateTimer(timer);
            }
        }
        else
        {
            TerminarPartida(false);
        }
    }

    public void TerminarPartida(bool gano)
    {
        if (juegoTerminado) return;

        juegoTerminado = true;
        Time.timeScale = 0f;

        if (uiManager != null)
        {
            if (gano)
                uiManager.MostrarPantallaWin();
            else
                uiManager.MostrarPantallaGameOver();
        }
    }
}