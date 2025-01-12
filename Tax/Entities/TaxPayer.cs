using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax.Entities
{
    public abstract class TaxPayer
    {
        public string Name { get; set; }
        public double Income { get; set; }
        public TaxPayer(string name, double income) 
        {
            Name = name;
            Income = income;
        }
        public abstract double Tax();
    }
}
