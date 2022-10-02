using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance = null;
    public int Score { get; private set; }
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private int _scoreMultiplier = 10;

    private void Awake()
    {
        //Singleton
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;

        Score = 0;
        UpdateScore();
    }

    private void UpdateScore()
    {
        _scoreText.text = "Points: " + Score;
    }

    public void AddScore()
    {
        Score += _scoreMultiplier;
        UpdateScore();
    }
}
