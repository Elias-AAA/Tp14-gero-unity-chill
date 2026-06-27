using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI textoPuntaje;
    public TextMeshProUGUI textoTemporizador;

    public void UpdateScore(int score)
    {
        if (textoPuntaje != null)
        {
            textoPuntaje.text = "Score: " + score;
        }
    }

    public void UpdateTimer(float time)
    {
        if (time < 0) time = 0;
        textoTemporizador.text = "00:" + Mathf.CeilToInt(time).ToString("00");
    }
}