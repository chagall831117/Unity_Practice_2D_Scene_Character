using UnityEngine;

public class LearnIf : MonoBehaviour
{
    [Range(0,100)]
    public int Score;
    [Range(5,500)]
    //一個整數值Combo
    public int Combo;
    public bool ZaWarudo; 
    // Start is called before the first frame update
    void Start()
    {
        //If (布林值)為true的時候執行
        if (9 == 6/2*(2+1))
        {
            print("答案是對的");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //考試時間
        if (ZaWarudo)
        {
            print("Stoping Time");
        }
        else
        {
            print("Time keep going");
        }
        if (Score >= 80)
        {
            print("你好像很會考試嘛");
        }
        else if (Score >= 60)
        {
            print("及格了");
        }
        else print("可以去跳海了");
        //COMBO攻擊力
        if (Combo >= 150 )
        {
            print("攻擊力10倍");
        }
        else if (Combo >= 100)
        {
            print("攻擊力5倍");
        }
        else if (Combo >= 50)
        {
            print("攻擊力2倍");
        }
        else
        {
            print("攻擊力一倍");
        }
    }
}
