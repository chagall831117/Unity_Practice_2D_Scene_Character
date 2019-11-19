using UnityEngine; //使用unity API

public class LearnEvents : MonoBehaviour
{
    //事件
    //在特地時間點以指定次數執行
    //開始事件
    //播放後執行一次
    //語法:修飾詞 傳回類型 名稱(){}
    //有傳回語法
    private string PlayerName(string name)
    {
        return ("嗨" + name + "你好");
    }
    /// <summary>
    /// 定義弓箭數量與方向
    /// </summary>
    /// <param name="count"></param>
    /// <param name="direction"></param>
    //多重參數
    private void bow(int count, string direction = "前方",string prop ="無")
    {
        print("弓箭數量：" + count);
        print("弓箭方向：" + direction);
        print("弓箭屬性：" + prop);
    }
    /// <summary>
    /// 跳躍速度為多少
    /// </summary>
    /// <param name="speed"></param>
    private void Jumpspeed(int speed)
    {
        print("跳躍速度為" + speed);
    }

    private void Start()
    {
        Jumpspeed(50);
        bow(1);
        bow(50,"全方位");
        bow(500, prop: "火"); 
        print("Wryyyyyyyyyyyyyyyyyyyyyyyyyyy~");
        print(PlayerName("Kate yup"));
        string PN = PlayerName(("kate yup"));
        print(PN);
    }
    //更新事件
    //每一幀將會執行一次 (60/s)
    private void Update()
    {
        print("無馱,歐拉");
    }
}
