using UnityEngine;

public class 水車 : MonoBehaviour
{
    public Rigidbody2D YiYung;
    public Transform YiTF;
    public Collider2D WaterCar1;
    public Collider2D WaterCar2;
    // Start is called before the first frame update

    public void Fly()
    {
        YiTF.position = new Vector3(-1.8f, -3.3f);  
        YiYung.Sleep();
        YiYung.gravityScale = 1;
        YiYung.AddForce(new Vector2(1, 10), ForceMode2D.Impulse);
     }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
