using UnityEngine;

public class 小雞 : MonoBehaviour
{
    [Header("小雞跳躍的速度")]
    [Tooltip("用來調整小雞跳躍的速度")]
    [Range(0.1f,5)]
    public float JumpSpeed = 2.5f; //跳躍速度
    [Header("小雞是否死亡")]
    [Tooltip("用來確認小雞的死亡狀態,打勾為死亡")]
    public bool Dead = false; //是否死亡
    /// <summary>
    /// 小雞跳躍控制
    /// </summary>
    private void Jump()
    {

    }
    /// <summary>
    /// 
    /// 小雞死亡控制
    /// </summary>
    private void Death()
    {

    }
    /// <summary>
    /// 小雞通過水管
    /// </summary>
    private void Through()
    {

    }
}
