using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int playerScore;
    [SerializeField] private int playerHighScore;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI highScoreText;
    
    void Start()
    {
        playerScore = 0;
        playerHighScore = PlayerPrefs.GetInt("Highscore");
        highScoreText.text = $"Highscore: {playerHighScore}";

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = $"Player Score: {playerScore}";
    }

    public void AddScore(int value) => playerScore += value;
    
    public void SaveScore()
    {
        if(playerScore > playerHighScore)
        {
            playerHighScore = playerScore;
            highScoreText.text = $"Highscore: {playerHighScore}";
            PlayerPrefs.SetInt("Highscore", playerHighScore);
            PlayerPrefs.Save();
        }
        
    }
}
