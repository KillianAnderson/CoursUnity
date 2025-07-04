using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float gameDuration = 60f;
    private float timeRemaining;
    private bool gameIsRunning = false;
    public GameObject restartButton;
    public BallShooter shooter;

    public void StartGame()
    {
        gameIsRunning = true;
        timeRemaining = gameDuration;
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
        Table.Instance.ResetTable();
        Table.Instance.cibleSphere.SetActive(true);
    }
}
