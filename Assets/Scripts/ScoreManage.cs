using UnityEngine;
using TMPro;
using System;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    private int score = 0;
    public TextMeshProUGUI scoreText;

    void Awake()
    {
        Instance = this;
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "Score : " + score;
    }

    public void ResetScore()
    {
        score = 0;
        scoreText.text = "Score : " + score;
    }

}
