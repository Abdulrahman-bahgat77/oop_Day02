using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace oop_Day02.encapsulation
{

    internal struct Employee
    {
        #region Attributes
        //public int Id;
        //private string Name;
        //private double salary;
        #endregion

        #region Constructor
        //public Employee(int id, string name, double _salary)
        //{
        //    Id = id;
        //    Name = name;
        //    salary = _salary;
        //}
        #endregion
        #region Methods
        //public override string ToString()
        //{
        //    return $"id: {Id}\n name: {Name}\nsalary: {salary}";
        //}
        #endregion

        #region Encapsulation
        //encapsulation:separate data defination.
        //From its Use [Getter,Setter].
        #region 1.Applay getter and setter
        //1.private attribute
        //2.getter-setter

        //Getter
        //public string Getname()
        //{
        //    return Name;
        //}

        //Setter
        //public void Setname(string value)
        //{
        //    Name = value;
        //}
        #endregion

        #region 2.Apply property
        //public double Salary
        //{
        //    get { return salary; }
        //    set { salary = value; }
        //}

        //full prop==>propfull
        //private int test;

        //public int Test
        //{
        //    get { return test; }
        //    set { test = value; }
        //}

        //automatic prop ==>prop
        //public int Test { get; set; }

       // private double deduction; ==>derived attribute

        //public double Deduction
        //{
        //    get { return salary * .2; }
            
        //}

        #endregion
        #endregion

        

    }
}
