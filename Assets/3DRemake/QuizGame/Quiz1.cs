using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quiz1 : MonoBehaviour
{
   public List<QuestionAnswers> QnA;
   public GameObject[] options;
   public int currentQuestion;
   public Text QuestionText;
   public Text scoreText;
   int totalQuestions;
   private int score;
   
   public int wrongAns = 0;

   public GameObject QuizPanel;
   public GameObject GameOverPanel;


   private void Start() {
       totalQuestions = QnA.Count;
       GameOverPanel.SetActive(false);
       QuizPanel.SetActive(true);
       GenerateQuestions();
       
   }


   public void GameOver(){
       GameOverPanel.SetActive(true);
       QuizPanel.SetActive(false);
        score =  totalQuestions - wrongAns;   
        scoreText.text = score + " / " + totalQuestions; 
       
   }

   public void correct() {
    
     QnA.RemoveAt(currentQuestion);
     StartCoroutine(WaitForNext());
  
     
   }
   
   public void wrong(){
     wrongAns++;   
     QnA.RemoveAt(currentQuestion);   
     StartCoroutine(WaitForNext());
    
   }
   IEnumerator WaitForNext()
    {
        yield return new WaitForSeconds(1);
        GenerateQuestions();
        
    }

   void SetAnswer() {
       for (int i = 0; i < options.Length ; i++){
           options[i].GetComponent<Answer1>().isCorrect = false;
           options [i].GetComponent <Image>().color = options [i].GetComponent<Answer1>().startColor;
         //text choices
         // options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];
          //3D ver test
           //options[i].transform.gameObject = QnA[currentQuestion].Answers[i];
        //image choices
           options[i].transform.GetChild(0).GetComponent<Image>().sprite = QnA[currentQuestion].Answers[i];

           if (QnA[currentQuestion].correctAnswer == i+1)
           {
                options[i].GetComponent<Answer1>().isCorrect = true;
           }
       }

   }

   void GenerateQuestions() {

       if (QnA.Count > 0)
       {
            currentQuestion = Random.Range(0, QnA.Count);
            QuestionText.text = QnA[currentQuestion].Question;
            SetAnswer();
       }
       else
       {
           Debug.Log("End of Quiz");
           GameOver();
       }
    


   }
}
