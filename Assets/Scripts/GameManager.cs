using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private ScoreManager scoreManager;
    private void Awake()
    {
        
    }
    void Start()
    {
        //startButton.onClick.AddListener(StartGame);
        StartGame();
    }


    public void StartGame()
    {
        Time.timeScale = 1;
    }

    public void EndGame()
    {
        scoreManager.SaveScore();
        Time.timeScale = 0;
    }
}
