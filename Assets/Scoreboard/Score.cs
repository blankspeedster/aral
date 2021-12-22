using System;

[Serializable]
public class Score
{
    public string name1;
    public float score;

    public Score(string name1, float score)
    {
        this.name1 = name1;
        this.score = score;
    }
}