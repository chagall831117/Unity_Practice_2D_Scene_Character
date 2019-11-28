using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    //Operator 算術運算子
    //+,-,*,/,%
    public int a = 30, b = 7;
    // Start is called before the first frame update
    void Start()
    {
        print(a + b);
        print(a - b);
        print(a / b);
        print(a * b);
        print(a % b);
        print(6 / 2*(2 + 1));
        print(a++);
        print(++a);

        // 並且 && 若有一邊是False則傳回False
        print(true&&true);
        print(true&&false);
        print(false&&true);
        print(false&&false);

        //或者 || 若有一邊是True則傳回True
        print(true||true);
        print(false||true);
        print(true||false);
        print(false||false);

        //
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
