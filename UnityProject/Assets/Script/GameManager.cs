using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("目前分數")]
    [Tooltip("用來調整目前分數")]
    public int Score = 0;//目前分數

    [Header("最高分數")]
    [Tooltip("用來顯示最高分數")]
    public int Best = 0; //最高分數

    [Header("透明水管")]
    public GameObject SteathPipe;//GameObject 存放透明水管計分用

    [Header("水管")]
    public GameObject pipe;//GameObject 可以存放預置物 或是場景物件

    [Header("地板")]
    public GameObject floor;//GameObject 可以存放預置物 或是場景物件

    public GameObject UI; //宣告存放介面群組

    public GameObject YiYuan;//宣告存放水車義勇

    public GameObject YiRun;//宣告存放跑步義勇

    public 水車 Water;//宣告存放水車腳本

    public 跑步 Run;//宣告存放跑步腳本

    public Text TextScore;//宣告存放分數介面

    public Text TextBest;//宣告存放最高分數介面



    [Header("水管生成時間")]
    [Range(1, 50f)]
    public float Spawn = 1f;

    public void RandomCall()
    {
        print("Randompring"+Random.Range(0, 11)); //0,11的Range生成0~10的int
        if (Random.Range(0,11)>5)
        {
            CallYi();
        }
    }

    public void CallYi()
    {   
        YiYuan.SetActive(true);
        Water.Fly();
        YiRun.SetActive(false);
        Invoke("BackYi", 2f);
    }
    public void BackYi()
    {
        YiYuan.SetActive(false);
        YiRun.SetActive(true);
        Run.Push();
    }
    /// <summary>
    /// 水管生成
    /// </summary>
    public void SpawnPipe()
    {
        //實例化產生物件pipe
        //也可以縮寫為Instantiate(pipe)
        //因為有繼承object這個類別
        Object.Instantiate(pipe);
    }
    /// <summary>
    /// 有三圍向量以及四元數的地板生成
    /// </summary>
    public void VQSpawnfloor()
    {
        //Vector3 三維向量 x,y,z
        Vector3 pos = new Vector3(35.1f, -4.6f, 0);
        //Quaternion 四元數 x,y,z,w
        Quaternion rot = new Quaternion(0, 0, 0, 0);
        //Object.Instantiate(Objcet,Vector3,Quaternion) 三個控制參數測試
        Object.Instantiate(floor, pos, rot);
    }
    /// <summary>
    /// 有三圍向量以及四元數的水管生成
    /// </summary>
    public void VQSpawnPipe()
    {
        //浮點數y控制隨機Y軸位置
        float y = Random.Range(-0.7f, -2f);
        //Vector3 三維向量 x,y,z
        Vector3 pos = new Vector3(3f, y, 0);
        //Quaternion 四元數 x,y,z,w
        Quaternion rot = new Quaternion(0, 0, 0, 0);
        //Object.Instantiate(Objcet,Vector3,Quaternion) 三個控制參數測試
        Object.Instantiate(pipe, pos, rot);
    }
    /// <summary>
    /// 控制遊戲分數增加
    /// </summary>
    public void Plus(int Add)
    {
        Score += Add;
        //改變Score文字介面
        TextScore.text = Score + ""; //使用空字串將int形式的Score轉成string
        //TextScore.text = Score.ToString();//使用Tostring()方法將Score轉成string 
    }
    /// <summary>
    /// 最高分數設定
    /// </summary>
    public void BestScore()
    {            
        //改變Best文字介面
        TextBest.text = Best + "";//使用空字串將int形式的Best轉成string
        if (Score>Best)
        {
            Best = Score;
            PlayerPrefs.SetInt("BestScore", Score);
        }
    }

    /// <summary>
    /// 遊戲結束判定
    /// </summary>
    public void GameOver()
    {
        //開啟UI介面
        UI.SetActive(true);
        //將水管以及地板的速度歸零
        地板.speed = 0f;
    }
    public void Start()
    {
        //在遊戲開始
        Best = PlayerPrefs.GetInt("BestScore");
        //在開始時執行一次水管生成
        //VQSpawnPipe();
        InvokeRepeating("VQSpawnPipe", 0, Spawn);
        //延遲重複呼叫(方法名稱,開始時間,頻率)
        InvokeRepeating("VQSpawnfloor", 0, 20f);

        //InvokeRepeating("CallYi", Spawn/2, Spawn);
        InvokeRepeating("RandomCall", Spawn / 2, Spawn);
    }
    private void Update()
    {
        BestScore();
    }
}
