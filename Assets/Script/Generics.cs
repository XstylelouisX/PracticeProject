using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generics : MonoBehaviour
{
    public void Start()
    {
        BoxFactory boxFactory = new BoxFactory();
        boxFactory.Start();
    }

    class SquareBox
    {
        public SquareBox()
        {
            Debug.Log("正方形箱子");
        }
    }

    class TriangleBox
    {
        public TriangleBox()
        {
            Debug.Log("三角形箱子");
        }
    }

    class CircleBox
    {
        public CircleBox()
        {
            Debug.Log("圓形箱子");
        }
    }

    class BoxFactory
    {
        public BoxFactory()
        {
            Debug.Log("這是一間箱子工廠");
        }

        class GenericBoxMaker
        {
            public GenericBoxMaker()
            {
                Debug.Log("箱子製造機建置完成");
            }

            public object GetBox<T>() where T : new()
            {
                Debug.Log("產生合適的箱子");
                return new T();
            }
        }
        public void Start()
        {
            Debug.Log("工廠開始運作");
            GenericBoxMaker maker = new GenericBoxMaker();
            maker.GetBox<SquareBox>();
            maker.GetBox<TriangleBox>();
            maker.GetBox<CircleBox>();
        }
    }
}
