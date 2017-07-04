using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Company_Roster
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfEmployees = int.Parse(Console.ReadLine());
            var employees = new List<Employee>();
            for (int i = 0; i < numberOfEmployees; i++)
            {
                var employeeInfo = Console.ReadLine().Split();
                var employee = new Employee(
                    employeeInfo[0],
                    decimal.Parse(employeeInfo[1]),
                    employeeInfo[2],
                    employeeInfo[3]
                    );

                if (employeeInfo.Length > 4)
                {
                    int age;
                    if (int.TryParse(employeeInfo[4], out age))
                    {
                        employee.Age = int.Parse(employeeInfo[4]);
                    }
                    else
                    {
                        employee.Email = employeeInfo[4];
                    }
                }
                if (employeeInfo.Length > 5)
                {
                    employee.Age = int.Parse(employeeInfo[5]);
                }
                employees.Add(employee);
            }
            var departments = employees
                .GroupBy(em => em.Department)
                .Select(gr => new
                {
                    Name = gr.Key,
                    AverageSalary = gr.Average(em => em.Salery),
                    Employees = gr
                })
                .OrderByDescending(gr => gr.AverageSalary)
                .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {departments.Name}");
            foreach (var emp in departments.Employees.OrderByDescending(em => em.Salery))
            {
                Console.WriteLine(emp.PrintEmployeeInfo());
            }

        }
    }
}
