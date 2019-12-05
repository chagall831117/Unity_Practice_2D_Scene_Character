using UnityEngine;
using UnityEngine.UI;



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
    //宣告存放GM
    public GameManager GM;
    //宣告存放音源
    public AudioSource AUDBUF;
    //宣告存放音檔
    public AudioClip SoundJump, SoundAdd, SoundDead;

    [Header("小雞跳躍的速度")]
    [Tooltip("用來調整小雞跳躍的速度")]
    [Range(5f,20f)]
    public float JumpSpeed = 10f; //跳躍速度

    [Header("小雞是否死亡")]
    [Tooltip("用來確認小雞的死亡狀態,打勾為死亡")]
    public bool Dead = false; //是否死亡

    /// <summary>
    /// 小雞跳躍設定
    /// </summary>
    /// <param name="speed"></param>
    private void Jump(float speed)
    {
        //如果死了就跳出此方法
        if (Dead) return;

        //抓W和滑鼠左鍵為跳躍
        if (Input.GetKeyDown("w")||Input.GetKeyDown(KeyCode.Mouse0))
            {
            RBfly.Sleep(); //進入睡眠
            RBfly.AddForce(new Vector2(0,speed), ForceMode2D.Impulse); //給予推力
            RBfly.SetRotation(30); //給予旋轉角度\
            AUDBUF.PlayOneShot(SoundAdd);
            }
        //抓W和滑鼠左鍵為啟動
        if (Input.GetKeyDown("w")||Input.GetKeyDown(KeyCode.Mouse0))
        {
            //若有抓到則出現此訊息
            print("Pressed Mouse 0");
            //物件分數.遊戲管理器 啟動
            GOScore.SetActive(true);
            GOGameManager.SetActive(true);
            //改變蝴蝶的重力為2
            RBfly.gravityScale = 2;
        }
        RBfly.SetRotation(3 * RBfly.velocity.y);
    }
    /// <summary>
    /// 
    /// 小雞死亡控制
    /// </summary>
    public void Death()
    {
        if (Dead) return;
        Dead = true;
        //控制GM的Gameover控制項
        GM.GameOver();
        AUDBUF.PlayOneShot(SoundDead);
    }
    /// <summary>
    /// 小雞通過水管
    /// </summary>
    public void Passpipe()
    {
        if (Dead) return;
        GM.Plus(1);
        print("加分");
        AUDBUF.PlayOneShot(SoundAdd);
    }
    private void Update()
    {
        Jump(JumpSpeed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.name);
        Death();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name=="透明水管")
        {
            Passpipe();
        }

        else Death();
    }
}
