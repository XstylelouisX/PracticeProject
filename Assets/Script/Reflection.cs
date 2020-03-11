using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Reflection : MonoBehaviour
{
    //一、建立類別
    public class Personal
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Age { get; set; }
    }

    private void Start()
    {
        Personal personal = new Personal();
        //方法1
        Type type = personal.GetType();
        //方法2
        //Type type = Type.GetType("ReflectionProperty.Personal");
        //方法3
        //Type type = typeof(Personal);

        if (type == null)
        {
            Debug.Log("找不到類型");
            return;
        }

        //類別名稱
        Debug.Log(string.Format("Type FullName:{0}", type.Name));
        //類別定義
        PropertyInfo[] propertyInfos = type.GetProperties();
        foreach (PropertyInfo propertyInfo in propertyInfos)
        {
            Debug.Log(string.Format("Property FullName:{0}", propertyInfo.Name));
        }
    }
}
