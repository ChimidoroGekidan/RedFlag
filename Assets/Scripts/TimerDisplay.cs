using UnityEngine;

public class TimerDisplay : MonoBehaviour
{
    private int frameCount = 0;
    private int target_frame = 3;
    private bool IsFinished = false;

    void Start()
    {
        Debug.Log("3フレーム後にメッセージが出るはずです");
    }

    void update()
    {
        frameCount++;
        if (!IsFinished && frameCount == target_frame)
        {
            IsFinished = true;
            Debug.Log("3フレーム経過しました");
        }
    }
}