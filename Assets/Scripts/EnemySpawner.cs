using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private const int Slime = 0;
    private const int Goblin = 1;
    private const int Dragon = 2;

    private const int Easy = 0;
    private const int Normal = 1;
    private const int Hard = 2;

    private string[] enemies = { "スライム", "ゴブリン", "ドラゴン" };
    private string[] levels = { "かんたん", "ふつう", "むずかしい" };

    void Start()
    {
        Spawn(Hard, Slime);
    }

    void Spawn(int enemyType, int difficulty)
    {
        string enemy = enemies[enemyType];
        string level = levels[difficulty];
        Debug.Log(enemy + "が出現（難易度：" + level + "）");
    }
}