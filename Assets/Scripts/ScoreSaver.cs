using UnityEngine;

public class ScoreSaver : MonoBehaviour
{
    private int score = 0;

    void Start()
    {
        Debug.Log("ハイスコア: " + LoadHighScore());
        AddPoints(50);
        Debug.Log("50点追加後のハイスコア: " + LoadHighScore());
    }

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