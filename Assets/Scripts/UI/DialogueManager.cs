using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField]
    private Text nameText;
    public Text dialogueText;

    public Animator animator;
    private Button dialogButton;
    private Canvas dialogCanvas;
    private Canvas inputCanvas;
    
    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue){
      
        inputCanvas = GameObject.FindGameObjectWithTag("InputCanvas").GetComponent<Canvas>();
        inputCanvas.gameObject.SetActive(false);
        
        animator.SetBool("IsOpen", true);

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();

    }

    public void DisplayNextSentence() {

        if (sentences.Count == 0)
        {
            inputCanvas.gameObject.SetActive(true);
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence) {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue(){
       
        animator.SetBool("IsOpen", false);
    }
}
