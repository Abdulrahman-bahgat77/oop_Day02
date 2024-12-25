using System;
using System.Linq.Expressions;
using oop_Day02.encapsulation;
using oop_Day02.Inheritance;
using oop_Day02.Polymorphism;

namespace oop_Day02
{
    internal class Program
    {
        #region Overloading
      public static int Sum(int x, int y) {
            return x + y;
        }
        public static int Sum(int x, int y,int z)
        {
            return x + y;
        }
        public static double Sum(double x, int y)
        {
            return x + y;
        }
        public static double Sum(double x, double y)
        {
            return x + y;
        }
       
        #endregion
        static void Main(string[] args)
        {
            #region Encapsulation
            //Employee employee = new Employee(10,"abdo",10000);
            // Employee employee = new Employee(_salary:10000, name:"abdo ",id:12  );
            // Console.WriteLine(employee);

            //employee.Name = "ds";//Invalid
            //Console.WriteLine(employee.Name); //Invalid
            //Console.WriteLine(employee.Getname());

            //employee.Setname("bahgat");
            //Console.WriteLine(employee.Getname());

            //employee.Salary = 1000;

            //Employee employee = new Employee(10,"abdo",10000);
            //Console.WriteLine(employee);
            //Console.WriteLine("==========================");
            //Console.WriteLine(employee.Deduction);

            //Console.WriteLine("=================");
            //Employee employee1 = new Employee(20, "mm", 200000);
            //Console.WriteLine(employee1);
            //Console.WriteLine("=============================");
            //Console.WriteLine(employee1.Deduction);
            #endregion

            #region indexer
            //PhoneBook Note = new PhoneBook(3);
            //Note.Addperson(0, "abdo", 101233);
            //Note.Addperson(1, "Bahgat", 4567);
            //Note.Addperson(2, "Mohammed", 8910);


            //int value= Note.GetPersonNumber("abdo");
            //    Console.WriteLine(value==-1 ? "Not found" : value);

            //Note.SetPersonNumber("Bahgat", 0909);
            //Console.WriteLine(Note.GetPersonNumber("Bahgat"));
            //Note["abdo"] = 1991;
            //Console.WriteLine(Note["abdo"]);

            //string name = "moooa";
            //Console.WriteLine(name[0]);
            // name[0] = 'z'; //Invalid
            // indexer is Get only

            //for(int i = 0; i < Note.Size; i++)
            //{
            //    Console.WriteLine(Note[i]);  
            //}

            Car C1;
            //Declare referenc  from Type car
            // Can refer to an object from Type Car
            //Or Object from class inherit from Type car
            //Clr will allocate 4bytes in stack
            //Clr will allocate 0byte in Heap

            C1 = new Car(10, "BMW", 290);
            //new:
            //1.Allocate required Bytes [16Bytes]at Heap
            //2.intailize the allocated Bytes
            //3.Call user defined Constructor
            //4.Assign referenc C1 at Heap
            //Car C2 = new Car(20, "Audi");
            //Car C3 = new Car(30);
            //Console.WriteLine(C1);
            //Console.WriteLine("====================");
            //Console.WriteLine(C2);
            //Console.WriteLine("====================");
            //Console.WriteLine(C3);
            #endregion

            #region Inheritance
            //Parent p = new Parent(2,3);
            //Console.WriteLine(p);
            //Console.WriteLine($"product={p.product()}");


            //Child C = new Child(2, 3, 4);
            //Console.WriteLine(C);
            //Console.WriteLine($"product:{C.product()}");

            // TypeA ObjA = new TypeA();
            //  ObjA.X = 10;//invalid private
            //  ObjA.Y = 20;//invalid private

            //  TypeB ObjB = new TypeB();
            //  ObjA.X = 10;//invalid private
            //  ObjA.Y = 20;//invalid private

            #endregion

            #region Polymorphism
            #region Overloading
            // int res=Sum(1, 2);
            //Console.WriteLine($"result={res}");
            //int res = Sum(1, 2,3);
            //Console.WriteLine($"result={res}");
            // double res = Sum(3.1, 2.2);
            // Console.WriteLine($"result={res}");

            #endregion

            #region Overriding
            // Support class only
            //Function Overriding must be within Relationship [Inheritance]
            TypeA typeA = new TypeA(1);
            typeA.A = 10;
            typeA.myfunc1();
            typeA.myfunc2();
            Console.WriteLine("====================");
            TypeB typeB = new TypeB(1,2);
            typeB.A = 20;
            typeB.myfunc1();
            typeB.myfunc2();
            #endregion
            #endregion



        }
    }

 
    
    }

