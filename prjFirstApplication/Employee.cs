using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFirstApplication
{
    class Employee
    {
        //Property
        int Eid { get; set; }
        string? Empname { get; set; }
        string? Location { get; set; }
        int Salary { get; set; }
        int Did { get; } //Read only property

        //Constructor
        //Initialize values for the variables

        Employee()
        {
            Did = 101;
        }

        //Constructor Overloading
        //based on number of parameters & datatypes
        Employee(int Eid, string Empname, string Location, int Sal)
        {
            //This represents current class instance (employee) variable
            this.Eid = Eid;
            this.Empname = Empname;
            this.Location = Location;
            Salary = Sal;
        }

        void DisplayEmployee(Employee emp)
        {
            Console.WriteLine("Eid:{0} || EmpName:{1} || Location:{2} || Salary:{3} || Did:{4}",
                Eid, Empname, Location, Salary, emp.Did);
        }

        static void Main()
        {
            int Empid, Esalary;
            string ELocation, Ename;
            Employee employee = new Employee();

            //Property
            /*
             employee.Eid = 1001;
            employee.Empname = "ANU"
            employee.Location = "Chennai";
            employee.Salary = 670000;
            employee.Did = 101; //error its read only

            Console.WriteLine("eid:{0} ename:{1} location:{2} salary"{3} did:{4},
                employee.Eid, employee.Empname, employee.Location, employee.Salary, employee.Did);
             */

            //Constructor
            Console.WriteLine("Enter the Eid");
            Empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name");
            Ename = Console.ReadLine();
            Console.WriteLine("Enter the Location");
            ELocation = Console.ReadLine();
            Console.WriteLine("Enter the Salary");
            Esalary = Convert.ToInt32(Console.ReadLine());

            Employee employee1 = new Employee(Empid, Ename, ELocation, Esalary);

            employee1.DisplayEmployee(employee);
        }
    }
}

/*

//----------------Array Object--------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFirstApplication
{

    class Organization
    {
        internal static string OrgName = "LTI"; //static variable
        string City = "Chennai"; //non
    }
    class Employee
    {
        //Property
        int Eid { get; set; }
        string? Empname { get; set; }
        string? Location { get; set; }
        int Salary { get; set; }
        int Did { get; } //Read only property

        //Constructor
        //Initialize values for the variables

        Employee()
        {
            Did = 101;
        }

        //Constructor Overloading
        //based on number of parameters & datatypes
        Employee(int Eid, string Empname, string Location, int Sal)
        {
            //This represents current class instance (employee) variable
            this.Eid = Eid;
            this.Empname = Empname;
            this.Location = Location;
            Salary = Sal;
        }

        void DisplayEmployee(Employee emp)
        {
            Console.WriteLine("Eid:{0} || EmpName:{1} || Location:{2} || Salary:{3} || Did:{4}",
                Eid, Empname, Location, Salary, emp.Did);
        }

        static void Main()
        {
            int Empid, Esalary;
            string ELocation, Ename;
            Employee employee = new Employee();

            //Property
            /*
             employee.Eid = 1001;
            employee.Empname = "ANU"
            employee.Location = "Chennai";
            employee.Salary = 670000;
            employee.Did = 101; //error its read only

            Console.WriteLine("eid:{0} ename:{1} location:{2} salary"{3} did:{4},
                employee.Eid, employee.Empname, employee.Location, employee.Salary, employee.Did);
             */
/*
            //Constructor
            Console.WriteLine("Enter the Eid");
            Empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name");
            Ename = Console.ReadLine();
            Console.WriteLine("Enter the Location");
            ELocation = Console.ReadLine();
            Console.WriteLine("Enter the Salary");
            Esalary = Convert.ToInt32(Console.ReadLine());

            Employee employee1 = new Employee(Empid, Ename, ELocation, Esalary);

            employee1.DisplayEmployee(employee);
        }
    }
}
*/