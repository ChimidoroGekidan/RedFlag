using UnityEngine;
 
public class GameManager : MonoBehaviour
{
    [SerializeField] private ResultPanel resultPanel;
 
    private int score = 0;
    private int highScore = 0;
    private bool isBonusStage = false;
 
    public void EndLevel()
    {
        Time.timeScale = 0f;
        if (isBonusStage)
        {
            return;
        }
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
        }
        resultPanel.Show(score);
    }
}
 