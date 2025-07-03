using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float gameDuration = 60f;
    private float timeRemaining;
    private bool gameIsRunning = false;
    public GameObject restartButton;
    public BallShooter shooter;


    void Start()
    {
        timeRemaining = gameDuration;
    }

    public void StartGame()
    {
        gameIsRunning = true;
    }

    void Update()
    {
        if (!gameIsRunning) return;

        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerDisplay();
        }
        else
        {
            EndGame();
        }
    }

    void UpdateTimerDisplay()
    {
        int seconds = Mathf.CeilToInt(timeRemaining);
        timerText.text = "Time : " + seconds + "s";
    }

    void EndGame()
    {
        gameIsRunning = false;
        timeRemaining = 0;
        timerText.text = "Terminus";
        shooter.canShoot = false;
        restartButton.SetActive(true);
    }

    public void RestartGame()
    {
        ScoreManager.Instance.ResetScore();
        timeRemaining = gameDuration;
        gameIsRunning = true;
        shooter.canShoot = true;
        restartButton.SetActive(false);
    }
}
