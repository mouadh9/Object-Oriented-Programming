using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Encapsulation
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot be less than 3 symbols");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot be less than 3 symbols");
                }
                this.lastName = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <=0)
                {
                    throw new ArgumentException("Age cannot be zero or negative integer");
                }
                this.age = value;
            }
        }
        public double Salery
        {
            get { return this.salary; }
            set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva");
                }
                this.salary = value;
            }
        }

        public Person(string firstName, string lastName, int age,double salery)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salery = salery;
        }

        public void IncreaseSalary(double percent)
        {
            if (this.age > 30)
            {
                this.salary += salary * percent / 100;
            }
            else
            {
                this.salary += salary * percent / 200;
            }
        }

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} get {this.salary:f2} leva";
        }
    }
}
