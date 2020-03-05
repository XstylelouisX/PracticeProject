using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Linq : MonoBehaviour
{
    private void Start()
    {
        DelayLoad();
        FirstLoad();
    }

    //延遲載入(執行foreach取出每一個元素都會執行LINQ)
    private void DelayLoad()
    {
        string[] name = { "Tom", "Mary", "Charlie", "John" };
        //搜尋長度三的字串
        var query = from p in name where p.Length == 3 select p;

        foreach (var item in query)
        {
            Debug.Log("延遲載入:" + item.ToString());
        }
    }

    //預先載入(在執行foreach前，已執行完LINQ的查詢)
    private void FirstLoad()
    {
        string[] name = { "Tom", "Mary", "Charlie", "John" };
        //搜尋長度三的字串
        var query = from p in name where p.Length == 3 select p;
        //搜尋開頭為T的字串
        var loadedQuery = from p in query.ToList() where p.StartsWith("T") select p;

        foreach (var item in loadedQuery)
        {
            Debug.Log("預先載入:" + item.ToString());
        }
    }
}
