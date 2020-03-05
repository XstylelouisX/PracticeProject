using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsV2 : MonoBehaviour
{
    private void Start()
    {
        Tester.Start();
    }

    public class MyGenericArray<T>
    {
        private T[] array;
        public MyGenericArray(int size)
        {
            array = new T[size + 1];
        }

        //取得值
        public T getItem(int index)
        {
            return array[index];
        }
        //設定值
        public void setItem(int index, T value)
        {
            array[index] = value;
        }
    }

    class Tester
    {
        public static void Start()
        {
            //數組
            MyGenericArray<int> intArray = new MyGenericArray<int>(5);

            //設定值
            for (int i = 0; i < 5; i++)
            {
                intArray.setItem(i, i * 5);
            }
            //取得值
            for (int i = 0; i < 5; i++)
            {
                Debug.Log(intArray.getItem(i) + " ");
            }

            //字符組
            MyGenericArray<char> charArray = new MyGenericArray<char>(5);

            //設定值
            for (int i = 0; i < 5; i++)
            {
                charArray.setItem(i, (char)(i + 97));
            }
            //取得值
            for (int i = 0; i < 5; i++)
            {
                Debug.Log(charArray.getItem(i) + " ");
            }
        }
    }
}
