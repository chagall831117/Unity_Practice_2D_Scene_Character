using UnityEngine;

public class 地板 : MonoBehaviour
{
    //在所有相機都看不到的情況下
    private void OnBecameInvisible()
    {
        print("完蛋了，水管被超級摧毀了");
        Destroy(gameObject, 2);
    }
    //在所有相機都看到的情況下
    private void OnBecameVisible()
    {
        //print("看到了");
    }

    //靜態此類別共用 且必為隱藏
    [Header("地板移動速度")]
    [Tooltip("用來調整地板移動的速度")]
    [Range(0.1f,20)]
    public static float speed = 3f;//移動速度
    
    /// <summary>
    /// 放置地板物件
    /// </summary>
    public Transform floor;
    /// <summary>
    /// 控制地板的移動速度
    /// </summary>
    /// <param name="speed"></param>
    public void Move(float movespeed)
    {
        floor.Translate(new Vector3(-1,0,0)* Time.deltaTime*movespeed);
    }
    private void Update()
    {
        Move(speed);
    }
}
