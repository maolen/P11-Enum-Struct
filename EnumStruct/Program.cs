using System;
using static System.Console;

namespace EnumStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee()
            {
                Name = "Иванов И.И.",
                Vacancy = Vacancies.Clerk,
                Salary = 120000,
                HiringDate = new int[] { 01, 02, 2019 }
            };

            WriteLine(employee.Name);
            WriteLine(employee.Vacancy);
            WriteLine(employee.Salary);
            foreach(var i in employee.HiringDate)
            {
                Write($"{i} ");
            }
            ReadKey();
        }
    }
}
