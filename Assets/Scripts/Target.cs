using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Renderer renderer;

    [SerializeField][Tooltip("Place the dialogue box that matches the text you want")]
    private Dialogue dialogueBox;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DialogueOn()
    {
        dialogueBox.gameObject.SetActive(true);
    }

    void OnMouseDown()
    {
        DialogueOn();
        dialogueBox.StartDialogue();
    }

    private void OnMouseEnter()
    {
        renderer.material.color = Color.red;
    }

    private void OnMouseExit()
    {
        renderer.material.color = Color.white;
    }
}
