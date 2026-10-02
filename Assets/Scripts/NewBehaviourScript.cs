using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    private int c = 0;
    private int c2 = 2;

    void Start()
    {
        DoAction();
        DoAction2();
        Debug.Log("着地後、もう一度ジャンプできるか確認します");
        DoAction();
    }

    public void DoAction()
    {
        if (c < c2)
        {
            c++;
            if (rb != null)
            {
                rb.AddForce(Vector2.up * 5f, ForceMode2D.Impulse);
            }
            Debug.Log("ジャンプ成功");
        }
        else
        {
            Debug.Log("ジャンプできない");
        }
    }

    public void DoAction2()
    {
        c2 = 0;
        Debug.Log("着地");
    }
}
