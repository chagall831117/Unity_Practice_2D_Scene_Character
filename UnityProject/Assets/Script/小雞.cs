using UnityEngine;


public class 小雞 : MonoBehaviour
{
    //存放分數
    public GameObject GOScore;
    //存放遊戲管理器
    public GameObject GOGameManager;
    //宣告非靜態API小蝴蝶
    public Transform Butterfly;
    //宣告存放RB2D小蝴蝶
    public Rigidbody2D RBfly;

    [Header("小雞跳躍的速度")]
    [Tooltip("用來調整小雞跳躍的速度")]
    [Range(0.1f,5)]
    public float JumpSpeed = 2.5f; //跳躍速度

    [Header("小雞是否死亡")]
    [Tooltip("用來確認小雞的死亡狀態,打勾為死亡")]
    public bool Dead = false; //是否死亡

    /// <summary>
    /// 小雞跳躍設定
    /// </summary>
    /// <param name="speed"></param>
    private void Jump(float speed)
    {
        //抓W和滑鼠左鍵為跳躍
        if (Input.GetKeyDown("w")||Input.GetKeyDown(KeyCode.Mouse0))
            {
            RBfly.AddForce(transform.up * 4 * speed, ForceMode2D.Impulse);
            }
        //抓W和滑鼠左鍵為啟動
        if (Input.GetKeyDown("w")||Input.GetKeyDown(KeyCode.Mouse0))
        {
            //若有抓到則出現此訊息
            print("Pressed Mouse 0");
            //物件分數.遊戲管理器 啟動
            GOScore.SetActive(true);
            GOGameManager.SetActive(true);
            //改變蝴蝶的重力為3
            RBfly.gravityScale = 3;
        }
    }
    /// <summary>
    /// 
    /// 小雞死亡控制
    /// </summary>
    public void Death()
    {

    }
    /// <summary>
    /// 小雞通過水管
    /// </summary>
    public void Passpipe()
    {

    }
    private void Update()
    {
        Jump(JumpSpeed);
    }
}
