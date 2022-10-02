using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;
    public bool IsAlive = true;
    [SerializeField] private Image _trashImage;
    [SerializeField] private Text _trashText;
    [SerializeField] private TrashObject[] _trashObjects;
    private int _currentIndex = 0;

    private void Awake()
    {
        //Singleton
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;

        //Request First Trash Object
        NextTrash();
    }

    public void NextTrash()
    {
        if (_trashImage == null || _trashText == null) return;
        _currentIndex = Random.Range(0, _trashObjects.Length);
        _trashImage.sprite = _trashObjects[_currentIndex].Image;
        _trashText.text = _trashObjects[_currentIndex].Label;
    }

    public TrashEnum GetCurrentTrashCategory()
    {
        return _trashObjects[_currentIndex].Category;
    }
}
