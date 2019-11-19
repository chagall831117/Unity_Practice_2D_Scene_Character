using UnityEngine;

public class 地板 : MonoBehaviour
{
    [Header("地板移動速度")]
    [Tooltip("用來調整地板移動的速度")]
    [Range(0.1f,5)]
    public float speed = 2.5f;//移動速度

    /// <summary>
    /// 控制地板的移動速度
    /// </summary>
    /// <param name="speed"></param>
    public void Move(float movespeed)
    {

    }
}
