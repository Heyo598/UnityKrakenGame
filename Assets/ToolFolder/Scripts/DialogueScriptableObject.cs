using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[CreateAssetMenu(fileName = "DialogueScriptableObject", menuName =
    "ScriptableObjects/Dialogue")]
public class DialogueScriptableObject : ScriptableObject
{
    [Header("Text Options")]
    public string[] lines;
}
