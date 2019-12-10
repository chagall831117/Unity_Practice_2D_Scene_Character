using UnityEngine;

public class 跑步 : MonoBehaviour
{
    public Rigidbody2D YiYung;//宣告義勇的RigidBody2D
    public Transform YiTF;//選告義勇的Transform
    
    public void Push()
    {
        YiTF.position = new Vector3(0.18f, -3.4f);
        YiYung.Sleep();
        YiYung.AddForce(new Vector2(-2, 0), ForceMode2D.Impulse);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (YiTF.position.x <= -2.2f)
        {
            YiYung.Sleep();
        }
    }
}
