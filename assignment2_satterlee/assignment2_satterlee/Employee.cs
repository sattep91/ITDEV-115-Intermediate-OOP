using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2_satterlee
{
    class Employee
    {
        const double FEDERAL_TAX_RATE = .18;        //to hold federal tax rate
        const double SS_TAX_RATE = .06;             //to hold social security tax rate
        const double SALES_COMMISSION = .07;        //to hold sales commission amount
        const double RETIREMENT_RATE = .1;          //to hold retirement rate
        private string firstName;               
        private string lastName;
        private double totalSales;
        private double retirementAmount;
        private double ssAmount;
        private double federalAmount;
        private double netIncome;

        //Constructor accepts first name, last name, and sales amount
        public Employee(string fName, string lName, double sales)
        {
            firstName = fName;
            lastName = lName;
            totalSales = sales;
        }

      
        //Full name property
        public string Name
        {
            get{ return firstName + " " + lastName; }
            set 
            { 
                firstName = value;
                lastName = value;
            }
        }

        //Federal property
        public double Federal
        {
            get { return federalAmount; }
        }

        //Retirement property
        public double Retirement
        {
            get { return retirementAmount;}
        }

        //Social Security property
        public double SS
        {
            get { return ssAmount;}
        }

        public double NetIncome
        {
            get { return netIncome; }
        }

        //Method to calculate income based on commission
        public double CommissionIncome()
        {  
            netIncome = totalSales * SALES_COMMISSION;
            return netIncome;

        }

        //Method to calculate total withholdings amount
        public double CalculateWithholdings()
        {
            return federalAmount + retirementAmount + ssAmount;
        }

        //Calculate Federal tax withholdings
        public void CalculateFederal()
        {
            
            federalAmount = CommissionIncome() * FEDERAL_TAX_RATE;
            
         
        }

        //Calculate Retiremement contribution amount
        public void CalculateRetirement()
        {
            
            retirementAmount = CommissionIncome() * RETIREMENT_RATE;
            

        }

        //Calculate social security withholdings
        public void CalculateSS()
        {
           
            ssAmount = CommissionIncome() * SS_TAX_RATE;
            
        }

        //Calculate net income after withholdings
        public double CalculateIncome()
        {
            return CommissionIncome() - CalculateWithholdings();
        }


    }
}
