using UnityEngine; //使用unity API

public class LearnEvents : MonoBehaviour
{
    //事件
    //在特地時間點以指定次數執行
    //開始事件
    //播放後執行一次
    //語法:修飾詞 傳回類型 名稱(){}
    private void Start()
    {
        print("Wryyyyyyyyyyyyyyyyyyyyyyyyyyy~");
    }
    //更新事件
    //每一幀將會執行一次 (60/s)
    private void Update()
    {
        print("無馱,歐拉");
    }
}
