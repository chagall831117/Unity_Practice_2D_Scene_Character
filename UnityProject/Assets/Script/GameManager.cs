using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("目前分數")]
    [Tooltip("用來調整目前分數")]
    public int Score = 0;//目前分數
    [Header("目前分數")]
    [Tooltip("用來顯示最高分數")]
    public int Best = 100; //最高分數

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

    }
}
