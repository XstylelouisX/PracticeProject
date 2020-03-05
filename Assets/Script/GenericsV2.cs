using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsV2 : MonoBehaviour
{
    private void Start()
    {
        //Tester.Start();
        //Program.Start();
        TestDelegate.Start();
    }

    //泛型(Generic)基礎
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

    //泛型(Generic)方法
    class Program
    {
        private static void Swap<T>(ref T type1, ref T type2)
        {
            T temp;
            temp = type1;
            type1 = type2;
            type2 = temp;
        }

        public static void Start()
        {
            int a, b;
            char c, d;
            a = 10;
            b = 20;
            c = 'I';
            d = 'V';

            Debug.Log("交換前數值:");
            Debug.Log(a);
            Debug.Log(b);
            Debug.Log("交換前字符:");
            Debug.Log(c);
            Debug.Log(d);

            //交換
            Swap<int>(ref a, ref b);
            Swap<char>(ref c, ref d);

            Debug.Log("交換後數值:");
            Debug.Log(a);
            Debug.Log(b);
            Debug.Log("交換後字符:");
            Debug.Log(c);
            Debug.Log(d);
        }
    }

    //泛型(Generic)委託
    class TestDelegate
    {
        delegate T NumberChanger<T>(T n);
        private static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }

        public static void Start()
        {
            NumberChanger<int> nc1 = new NumberChanger<int>(AddNum);
            NumberChanger<int> nc2 = new NumberChanger<int>(MultNum);
            nc1(25);
            Debug.Log("加總和:" + getNum());
            nc2(5);
            Debug.Log("乘總和:" + getNum());
        }
    }
}
