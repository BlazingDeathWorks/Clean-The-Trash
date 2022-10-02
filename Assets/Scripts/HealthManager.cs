using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public static HealthManager Instance = null;
    [SerializeField] private Transform _healthContainer;
    [SerializeField] private GameObject _gameOverTab;
    private List<GameObject> _hearts = new List<GameObject>();
    private int _health;

    private void Awake()
    {
        //Singleton
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;

        foreach (Transform child in _healthContainer)
        {
            _hearts.Add(child.gameObject);
        }
        _health = _hearts.Count;
    }

    public void LoseHeart()
    {
        _health--;
        GameObject heart = _hearts[_hearts.Count - 1];
        _hearts.Remove(heart);
        Destroy(heart);

        if (_health <= 0)
        {
            GameManager.Instance.IsAlive = false;
            _gameOverTab.SetActive(true);
        }
    }
}
