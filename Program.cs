﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>();
            int i = 0;

            while (i <= 1)
            {
                Employee obj = new Employee()
                {
                    _name = Console.ReadLine(),
                    _id = Convert.ToInt32(Console.ReadLine()),
                    _address = Console.ReadLine()
                };
                emplist.Add(obj);
                i++;
            }
            Console.WriteLine(emplist.Capacity);
            foreach (var item in emplist)
            {
                Console.WriteLine(item._name);
                Console.WriteLine(item._id);
                Console.WriteLine(item._address);
            }
            IEnumerator enumerator = emplist.GetEnumerator();
            while (enumerator.MoveNext())
            {

                Employee obj1 = (Employee)enumerator.Current;
                //obj1.ShowDetails();
                Console.WriteLine(obj1._name);
                Console.WriteLine(obj1._id);
                Console.WriteLine(obj1._address);
            }
            //int[] array = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //foreach (var item in array)
            //{
            //    Console.Write(item);
            //    Console.WriteLine();
            //}
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add("Gourab");
            //arrayList.Add("Sinha");
            //arrayList.Add(1);
            //arrayList.Add(10.01);
            //foreach(var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //Array.Sort(array);
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}
            Console.ReadKey();
        }
    }
}
