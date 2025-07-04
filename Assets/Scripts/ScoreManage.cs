using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    private int score = 0;
    public TextMeshProUGUI scoreText;

    void Awake()
    {
        Instance = this;
    }

    public void AddScore(int point = 1)
    {
        score += point;
        scoreText.text = "Score : " + score;
    }

    public void ResetScore()
    {
        score = 0;
        scoreText.text = "Score : " + score;
    }

    public void SaveBestScore()
    {
        int bestScore = PlayerPrefs.GetInt("BestScore", 0);
        if (score > bestScore)
        {
            PlayerPrefs.SetInt("BestScore", score);
            PlayerPrefs.Save();
        }
    }


}
