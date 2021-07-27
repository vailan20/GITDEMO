using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFirstApplication
{
    class Datatypes
    {
        /*accessspecifier return type methodname (parameterlist){code}*/

        void Types()
        {
            String name;
            int age;
            float salary = 67900.89f;
            Console.WriteLine("Enter the Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the Age");
            age = Convert.ToInt32(Console.ReadLine());
                                     //placeholder
            Console.WriteLine("Name : {0} && Age : {1} && Salary : {2}", name, age, salary);

        }

        void TypeConversion()
        {
            //Implicit type conversion and explicit
            //Implicit type conversion
            //int<float<double
            int num = 100;
            float petrol = num;
            double disel = petrol;
            Console.WriteLine("Implicit type conversion :{0}", disel);

            //Explicit type Conversion



        }


        void BoxingandUnboxing()
        {
            //converting value type to reference
        }
        static void Main()
        {
                                 //creates memory
            Datatypes datatypes = new Datatypes();
            datatypes.Types();
            Console.WriteLine("------------------------------------");
        }
    }
}

