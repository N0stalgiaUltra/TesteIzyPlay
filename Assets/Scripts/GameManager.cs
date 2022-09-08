using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private ScoreManager scoreManager;
    private void Awake()
    {
        
    }
    void Start()
    {
        startButton.onClick.AddListener(ReloadScene);
        StartGame();
    }


    public void StartGame()
    {
        gameOverScreen.SetActive(false);
        Time.timeScale = 1;
    }

    public void EndGame()
    {
        gameOverScreen.SetActive(true);
        scoreManager.SaveScore();
        Time.timeScale = 0;
    }

    private void ReloadScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }
}
