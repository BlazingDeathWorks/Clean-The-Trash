using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewTrashObject", menuName = "Scriptable Objects/Trash Object")]
public class TrashObject : ScriptableObject
{
    public string Label;
    public Sprite Image;
    public TrashEnum Category;
}
