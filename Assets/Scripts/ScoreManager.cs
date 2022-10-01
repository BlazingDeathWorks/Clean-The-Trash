using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance = null;
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private int _scoreMultiplier = 10;
    private int _score;

    private void Awake()
    {
        //Singleton
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;

        _score = 0;
        UpdateScore();
    }

    private void UpdateScore()
    {
        _scoreText.text = "Points: " + _score;
    }

    public void AddScore()
    {
        _score += _scoreMultiplier;
        UpdateScore();
    }
}
