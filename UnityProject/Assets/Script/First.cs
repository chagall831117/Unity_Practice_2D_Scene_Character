using UnityEngine; //引用自Unity API

//    類別   類別名稱
public class First : MonoBehaviour
{
    public int level = 1; //整數 等級
    public float speed = 10.5f; //浮點數 走路速度
    public string prop = "一等物件"; //字串
    public bool mission = true ; // 布林值 是否值 任務

    //屬性
        //標題
        //語法:[屬性名稱(屬性內容)]
    [Header("血量")]
    public int HP = 100;

        //提示
        //語法:[提示("提示內容")]
    [Tooltip("確認角色是否死亡")]
    public bool 是否死亡;
        //數值範圍
        //語法:[範圍(最小值,最大值)]
    [Range(0,900)]
    public int mp = 50 ;

}
