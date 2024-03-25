using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerConsoleApp
{
    public class TaxRepository
    {
        Dictionary<Employee, Double> taxSchemes;

        public TaxRepository()
        {
            taxSchemes = new Dictionary<Employee, Double>();
        }

        public void addToTaxScheme(Employee employee, Double tax)
        {
            taxSchemes.Add(employee, tax);
        }

    }
}
