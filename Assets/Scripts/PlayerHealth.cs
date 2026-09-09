using UnityEngine;
 
public class PlayerHealth : MonoBehaviour
{
    private int hp = 100;
 
    public void TakeDamageFromEnemy(int amount)
    {
        Debug.Log("敵からダメージを受けた");
        hp -= amount;
        if (hp <= 0)
        {
            Die();
        }
    }
 
    public void TakeDamageFromHazard(int amount)
    {
        Debug.Log("トラップのダメージを受けた");
        hp -= amount;
        if (hp <= 0)
        {
            Die();
        }
    }
 
    private void Die()
    {
        Debug.Log("プレイヤーが死亡した");
    }
}