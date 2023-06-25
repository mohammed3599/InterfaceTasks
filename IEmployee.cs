using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    interface IEmployee
    {
        string GetName();
        decimal GetSalary();
        string GetJobTitle();
    }

    class FullTimeEmployee : IEmployee
    {
        public string name;
        public decimal salary;
        public string jobTitle;

        public FullTimeEmployee(string name, decimal salary, string jobTitle)
        {
            this.name = name;
            this.salary = salary;
            this.jobTitle = jobTitle;
        }

        public string GetName()
        {
            return name;
        }

        public decimal GetSalary()
        {
            return salary;
        }

        public string GetJobTitle()
        {
            return jobTitle;
        }
    }

    class PartTimeEmployee : IEmployee
    {
        public string name;
        public decimal payByHour;
        public int workingHours;

        public PartTimeEmployee(string name, decimal payByHour, int workingHours)
        {
            this.name = name;
            this.payByHour = payByHour;
            this.workingHours = workingHours;
        }

        public string GetName()
        {
            return name;
        }

        public decimal GetSalary()
        {
            return payByHour * workingHours;
        }

        public string GetJobTitle()
        {
            return "Part-time employee";
         }
      }
   }
