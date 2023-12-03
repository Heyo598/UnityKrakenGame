using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[CreateAssetMenu(fileName = "DialogueScriptableObject", menuName =
    "ScriptableObjects/Dialogue")]
public class DialogueScriptableObject : ScriptableObject
{
    public TextMeshProUGUI textComponent;

    [Header("Text Options")]
    public string[] lines;
    public float textSpeed;

    private int index;

    void Start()
    {
        textComponent.text = string.Empty;
    }
}
