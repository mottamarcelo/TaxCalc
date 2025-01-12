using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }
        public Individual(string name, double income, double healthExpenditures) : base(name, income)
        {
            HealthExpenditures = healthExpenditures;
        }
        public override double Tax()
        {
            if (Income < 20000)
            {
                return Income * 0.15 - HealthExpenditures * 0.5;
            }
            else
            {
                return Income * 0.25 - HealthExpenditures * 0.5;
            }
        }
    }
}
