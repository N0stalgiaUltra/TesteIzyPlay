using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int playerScore;

    public static ScoreManager instance;
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(instance);
    }
    
    void Start()
    {

        playerScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int value) => playerScore += value;
}
