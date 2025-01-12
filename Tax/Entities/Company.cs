using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax.Entities
{
    internal class Company : TaxPayer
    {
        public int Employees { get; set; }
        public Company(string name, double income, int employees) : base(name, income)
        {
            Employees = employees;
        }
        public override double Tax()
        {
            if (Employees <= 10)
            {
                return Income * 0.16;
            }
            else 
            {
                return Income * 0.14; 
            }

        }
    }
}
