using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quiz : MonoBehaviour
{
   public List<QuestionAnswers> QnA;
   public GameObject[] options;
   public int currentQuestion;
   public Text QuestionText;
   public Text scoreText;
  // public Text scoreSaveText;
   int totalQuestions;
   public static int score;
  
   
   public int wrongAns = 0;

   public GameObject QuizPanel;
   public GameObject GameOverPanel;
  // public GameObject scoreSavePanel;

   //public static string namePlayer = "NewPlayer";
  // public Text nameInput;


   private void Start() {
     //  namePlayer = nameInput.text;
      // namePlayer = nameInput.text.ToString();
       totalQuestions = QnA.Count;
       GameOverPanel.SetActive(false);
   //    scoreSavePanel.SetActive(false);
    //   QuizPanel.SetActive(true);
       GenerateQuestions();
       
   }

   public void Retry(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }

   public void Home(){
       SceneManager.LoadScene("Menu");
   }

   public void GameOver(){
       GameOverPanel.SetActive(true);
       QuizPanel.SetActive(false);
        score =  totalQuestions - wrongAns;   
        scoreText.text = score + " / " + totalQuestions; 
      //  scoreSaveText.text = score.ToString();
   }

   public void ScoreSave() {
       GameOverPanel.SetActive(false);
     //  scoreSavePanel.SetActive(true);
      
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
           options[i].GetComponent<Answer>().isCorrect = false;
           options [i].GetComponent <Image>().color = options [i].GetComponent <Answer>().startColor;
          //options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];
           options[i].transform.GetChild(0).GetComponent<Image>().sprite = QnA[currentQuestion].Answers[i];

           if (QnA[currentQuestion].correctAnswer == i+1)
           {
                options[i].GetComponent<Answer>().isCorrect = true;
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
