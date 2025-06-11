using System.Net.Http.Headers;

namespace Indexers
{
    public class Employee
    {
        int Eno;
        double Salary;
        string Ename, Job, Dname, Location;
        public Employee(int eno, double salary, string ename, string job, string dname, string location)
        {
           this. Eno = eno;
            Salary = salary;
            Ename = ename;
            Job = job;
            Dname = dname;
            Location = location;
        }
        public object this[int index]    //this - is used to define index of current class
        {
            get
            {
               if(index == 0)
                    return Eno;
               else if (index == 1)
                    return Salary;
                else if (index == 2)
                    return Ename;
                else if (index == 3)
                    return Job;
                else if (index == 4)
                    return Dname;
                else if (index == 5)
                    return Location;
                else
                    throw new IndexOutOfRangeException("Invalid index");
            }
            
            set
            {
                if (index == 0)
                    Eno = (int)value;
                else if (index == 1)
                    Salary = (double)value;
                else if (index == 2)
                    Ename = (string)value;
                else if (index == 3)
                    Job = (string)value;
                else if (index == 4)
                    Dname = (string)value;
                else if (index == 5)
                    Location = (string)value;
                else
                    throw new IndexOutOfRangeException("Invalid index");

            }
        }
        public object this[string  name]    //this - is used to define index of current class
        {
            get
            {
                if (name.ToUpper() =="ENO")
                    return Eno;
                else if (name.ToUpper() == "SALARY")
                    return Salary;
                else if (name.ToUpper() == "ENAME")
                    return Ename;
                else if (name.ToUpper() == "JOB")
                    return Job;
                else if (name.ToUpper() == "DNAME")
                    return Dname;
                else if (name.ToUpper() == "LOCATION")
                    return Location;
                else
                    throw new IndexOutOfRangeException("Invalid index");
            }
            set
            {
                if (name.ToUpper() == "ENO")
                    Eno = (int)value;
                else if (name.ToUpper() == "SALARY")
                    Salary = (double)value;
                else if (name.ToUpper() == "ENAME")
                    Ename = (string)value;
                else if (name.ToUpper() == "JOB")
                    Job = (string)value;
                else if (name.ToUpper() == "DNAME")
                    Dname = (string)value;
                else if (name.ToUpper() == "LOCATION")
                    Location = (string)value;   
                else
                    throw new IndexOutOfRangeException("Invalid index");
            }
        }

        }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Emp = new Employee(1001, 10000, "John", "Manager", "Raj","Hyderabad");
            Console.WriteLine("Eno:"+ Emp["Eno"]);
            Console.WriteLine("Salary:" + Emp[1]);
            Console.WriteLine("Ename:" + Emp[2]);
            Console.WriteLine("Job:" + Emp[3]);
            Console.WriteLine("Dname:" + Emp[4]);
            Console.WriteLine("Location:" + Emp[5]);

            //Modify 

            Emp["Dname"] = "Ajay";
            Emp[2] = "John Doe";

            Console.WriteLine("After Modification");

            Console.WriteLine("Eno:" + Emp[0]);
            Console.WriteLine("Salary:" + Emp[1]);
            Console.WriteLine("Ename:" + Emp[2]);
            Console.WriteLine("Job:" + Emp[3]);
            Console.WriteLine("Dname:" + Emp[4]);
            Console.WriteLine("Location:" + Emp[5]);



        }
    }
}
