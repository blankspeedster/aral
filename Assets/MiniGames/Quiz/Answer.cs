using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answer : MonoBehaviour
{
    public bool isCorrect = false;
    public Quiz quizManager;
    public Color startColor;

    private void Start() {
        startColor = GetComponent<Image>().color;
         
    }

   public void ColorReset() {
        GetComponent<Image>().color = startColor;
   }
   
    public void CheckAnswer() {
        if (isCorrect)
        {
            GetComponent<Image>().color = Color.green;
            print("Correct Answer");   
            quizManager.correct();
        }
        else
        {
            GetComponent<Image>().color = Color.red;
            print("Incorrect!");  
            quizManager.wrong();
        }
    }
}
