using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Lambda : MonoBehaviour
{
    private void Start()
    {
        LambdaSort();
        LambdaCalculation();
    }

    //排序
    private void LambdaSort()
    {
        int[] number = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //從小排到大(編程式查詢)
        IEnumerable<int> results = number.Where(x => x > 4).OrderBy(y => y);

        foreach (var item in results)
        {
            Debug.Log("編程式查詢:" + item.ToString());
        }
    }

    //計算
    private void LambdaCalculation()
    {
        int[] number = { 2, 3, 4, 5 };
        var squaredNumbers = number.Select(x => x * x);
        //插入分隔顯示
        Debug.Log(string.Join(" ", squaredNumbers));
    }
}
