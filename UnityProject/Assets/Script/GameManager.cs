using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("目前分數")]
    [Tooltip("用來調整目前分數")]
    public int Score = 0;//目前分數

    [Header("目前分數")]
    [Tooltip("用來顯示最高分數")]
    public int Best = 100; //最高分數

    [Header("透明水管")]
    public GameObject SteathPipe;//GameObject 存放透明水管計分用

    [Header("水管")]
    public GameObject pipe;//GameObject 可以存放預置物 或是場景物件

    [Header("地板")]
    public Transform floor;//GameObject 可以存放預置物 或是場景物件

    public GameObject UI; //宣告存放介面群組

    [Header("水管生成時間")]
    [Range(1, 50f)]
    public float Spawn = 1f;
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
    public void Plus()
    {

    }

    /// <summary>
    /// 最高分數設定
    /// </summary>
    public void BestScore()
    {

    }

    /// <summary>
    /// 遊戲結束判定
    /// </summary>
    public void GameOver()
    {
        UI.SetActive(true);
    }
    public void Start()
    {
        //在開始時執行一次水管生成
        //SpawnPipe();
        //VQSpawnPipe();
        InvokeRepeating("VQSpawnPipe", 0, Spawn);
        //延遲重複呼叫(方法名稱,開始時間,頻率)
        InvokeRepeating("VQSpawnfloor", 0, 20f);
    }
}
