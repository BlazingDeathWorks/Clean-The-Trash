using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashBin : MonoBehaviour
{
    [SerializeField] private TrashEnum Category;

    public void SelectBin()
    {
        Debug.Log(Category);
        //Check
    }
}
