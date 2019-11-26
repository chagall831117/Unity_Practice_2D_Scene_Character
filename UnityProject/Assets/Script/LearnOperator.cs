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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
