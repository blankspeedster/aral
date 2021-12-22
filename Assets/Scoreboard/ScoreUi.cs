using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreUi : MonoBehaviour
{
    public RowUi rowUi;
    public ScoreManager scoreManager;
    private int newScore;
    private string newName;
    
    private void Start() {
         var scores = scoreManager.GetHighScores().ToArray();
        for (int i = 0; i < scores.Length; i++)
        {
            var row = Instantiate(rowUi, transform).GetComponent<RowUi>();
            row.rank.text = (i + 1).ToString();
            row.name1.text = scores[i].name1;
            row.score.text = scores[i].score.ToString();
        }
    }

    public void ApplyScore()
    {
     
        newScore = Quiz.score;
        newName = Quiz.namePlayer;
        //scoreManager.AddScore(new Score(name1:"Jc",score:2002));

        scoreManager.AddScore(new Score(name1:newName, score:newScore));

        
    }
}