using UnityEngine;
 
public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
 
    private int c = 0;
    private int c2 = 2;
 
    public void DoAction()
    {
        if (c < c2)
        {
            c++;
            rb.AddForce(Vector2.up * 5f, ForceMode2D.Impulse);
        }
    }
 
    public void DoAction2()
    {
        c2 = 0;
    }
}