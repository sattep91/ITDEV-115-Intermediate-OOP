using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace assignment2_satterlee
{
    class Payroll
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            double totalSales;
            string inValue;

            Info info = new Info();
            info.DisplayInfo();

            WriteLine("Please enter the employee's first name: ");
            firstName = ReadLine();

            WriteLine("Please enter the employee's last name: ");
            lastName = ReadLine();

            WriteLine("Please enter the employees total sales for the month: ");
            inValue = ReadLine();
            totalSales = double.Parse(inValue);


            Employee employee = new Employee(firstName, lastName, totalSales);

            employee.CalculateFederal();
            employee.CalculateSS();
            employee.CalculateRetirement();

            WriteLine("Name: {0}", employee.Name);
            WriteLine();
            WriteLine("Employee Gross Income:           {0:C}", employee.CommissionIncome());
            WriteLine("Federal Tax Witheld:             {0:C}", employee.Federal);
            WriteLine("Social Security Tax Witheld:     {0:C}", employee.SS);
            WriteLine("Retirement Contributions:        {0:C}", employee.Retirement);
            WriteLine();
            WriteLine("Employee Net Pay:                {0:C}", employee.CalculateIncome());

            ReadKey();
        }
    }
}
