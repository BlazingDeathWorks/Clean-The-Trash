using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashBin : MonoBehaviour
{
    [SerializeField] private TrashEnum Category;

    public void SelectBin()
    {
        if (!GameManager.Instance.IsAlive) return;
        if (GameManager.Instance.GetCurrentTrashCategory() == Category) ScoreManager.Instance.AddScore();
        else HealthManager.Instance.LoseHeart();
        GameManager.Instance.NextTrash();
    }
}
