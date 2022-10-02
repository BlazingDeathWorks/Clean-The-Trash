using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] private Text _congratsText;

    private void Awake()
    {
        _congratsText.text = $"Congratulations!\nYou Got {ScoreManager.Instance.Score} Points!";
    }
}
