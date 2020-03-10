using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interface : MonoBehaviour
{
    //更改
    interface ISampleInterface
    {
        void SampleMethod();
    }

    private void Start()
    {
        ImplementationClass.Start();
        TestClass.Start();
    }

    class TestClass : ISampleInterface
    {
        void ISampleInterface.SampleMethod()
        {
            Debug.Log("測試類別");
        }
        public static void Start()
        {
            ISampleInterface obj = new TestClass();
            obj.SampleMethod();
        }
    }

    class ImplementationClass : ISampleInterface
    {
        void ISampleInterface.SampleMethod()
        {
            Debug.Log("簡單方法");
        }

        public static void Start()
        {
            ISampleInterface obj = new ImplementationClass();
            obj.SampleMethod();
        }
    }
}
