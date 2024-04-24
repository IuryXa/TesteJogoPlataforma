using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{
    public int moedas;
    public TMP_Text moedasTexto;
    public int Score;
    public TMP_Text ScoreTexto;
    public float Tempo = 230;
    public TMP_Text TempoTexto;
    void Start()
    {
        ScoreTexto.SetText(Score.ToString());
        moedasTexto.SetText(moedas.ToString());
        TempoTexto.SetText(Tempo.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        Tempo -= Time.deltaTime;
        ScoreTexto.SetText($"Score:{Score}");
        moedasTexto.SetText($"Moedas:{moedas}");
        TempoTexto.SetText($"Tempo:{Tempo}");
    }
}
