using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;

    [SerializeField][Tooltip("Place desired text for this object")]
    private DialogueScriptableObject dialogueScriptableObject;

    [Header("Text Options")]
    [SerializeField][Range(0.01f,0.1f)]
    private float textSpeed;

    [SerializeField][Range(50,100)]
    private int textSize;

    [Header("Text Color")]
    [SerializeField][Range(0,1)]
    private float Red;

    [SerializeField][Range(0,1)]
    private float Green;

    [SerializeField][Range(0,1)]
    private float Blue;

    private int index;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        textComponent.text = string.Empty;
        textComponent.fontSize = textSize;
        textComponent.color = new Color(Red, Green, Blue);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == dialogueScriptableObject.lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = dialogueScriptableObject.lines[index];
            }
        }
    }

    public void StartDialogue()
    {
        index = 0;
        gameObject.SetActive(true);
        StartCoroutine(TypeLine()); 
    }

    IEnumerator TypeLine()
    {
        foreach (char c in dialogueScriptableObject.lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < dialogueScriptableObject.lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
