using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LambdaV2 : MonoBehaviour
{
    private void Start()
    {
        Demo.Start();
    }

    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Demo
    {
        public static void Start()
        {
            var empList = new List<Employee>()
            {
                new Employee{ Name = "Michael", Age = 20},
                new Employee{ Name = "Douglas", Age = 25},
                new Employee{ Name = "Jenifer", Age = 14}
            };
            //找出開頭為J的名子
            //方法1(Lambda)
            Predicate<Employee> p = e => e.Name.StartsWith("J");
            Employee emp1 = empList.Find(p);
            Debug.Log(emp1.Name);
            //方法2(delegate)
            Predicate<Employee> k = delegate (Employee e)
            {
                return e.Name.StartsWith("J");
            };
            Employee emp2 = empList.Find(k);
            Debug.Log(emp2.Name);
        }
    }
}
