using UnityEngine;

public class ScoreSavers : MonoBehaviour
{
    private int score = 0;
 
    public void AddPoints(int amount)
    {
        score += amount;
        PlayerPrefs.SetInt("HighScore", score);
    }
 
    public int LoadHighScore()
    {
        return PlayerPrefs.GetInt("Highscore");
    }
}
