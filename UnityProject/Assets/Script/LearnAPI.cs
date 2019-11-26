using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    public Transform Chiken;
    public Transform Camera;
    public SpriteRenderer Butterfly;

    private void Start()
    {
        //非靜態成員的取得

        print("小雞位置"+Chiken.position);
        print("鏡頭位置"+Camera.position);

        //非靜態成員的位置改變
        //Chiken.position = new Vector3(-3, 0, 0);
        //圖片翻轉X軸
        //Butterfly.flipX = true;


        Debug.Log("一般!");
        Debug.LogWarning("警告!");
        Debug.LogError("錯誤!");

        //靜態成員的取得
        
        //Mathf
        //Random.value Test 產生隨機0~1的數值
        print("RandomValueResult="+Random.value);
        //Mathf.Deg2Rad Test 將角度化為數值
        print("pi="+180 * Mathf.Deg2Rad);
        float pie = 180 * Mathf.Deg2Rad;
        //Mathf.Rad2Deg Test 將數值化為角度
        print("Rad2DegTest=" + pie * Mathf.Rad2Deg);
        //Mathf.PI Test 就是拍的數值
        print("PI="+Mathf.PI);
        //Math.Epsilon Test 產生超微小數字
        print("Epsilon Test"+Mathf.Epsilon);
    }
    private void Update()
    {
        //控制小雞的尺寸 以每幀1,1的速度長大
        //Chiken.localScale = Chiken.localScale+ new  Vector3(1, 1, 0);
        //紀錄每一幀鍵盤所按下的按鍵
        print(Input.inputString);

        //練習，請偵測玩家有沒有按s
        if (Input.GetKeyDown("s"))
            {
            print("the key s was pressed");
            }
    }
}
