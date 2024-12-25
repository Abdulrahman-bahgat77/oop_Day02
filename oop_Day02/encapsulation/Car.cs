using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace oop_Day02.encapsulation
{
    internal class Car
    {
        #region Properties
        public int Id { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"CarId:{Id}\nmodel:{Model}\nSpeed:{Speed}";
        }

        #endregion

        #region Constructor
        //constructor in Class
        // If There is no User defined Constructor,
        // Compiler Will Always Generate Empty Parameterless constructor => Will do Nothing.

        //If You defined a User defined Constructor ,
        //Compiler Will No Longer Generate Empty Parameterless constructor.

        //Empty Parameterless constructor
        public Car()
        {
            //Do Nothing
        }
        public Car(int id, string model, int speed)
        {
            Id = id;
            Model = model;
            Speed = speed;
        }
        public Car(int id,string model):this(id,model,190)
        {
            Console.WriteLine("ctro2");
        }

        public Car(int id) 
        {
            Id = id;
            Model = "Hundi";
            Speed = 200;
        }
        #endregion
    }
}
