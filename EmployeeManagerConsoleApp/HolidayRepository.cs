using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerConsoleApp
{
    public class HolidayRepository
    {
        Dictionary<Employee, Double> holidaysRepo;
        public HolidayRepository()
        {
            holidaysRepo = new Dictionary<Employee, Double>();
        }

        public void addHolidays(Employee employee, Double holidays)
        {
            holidaysRepo.Add(employee, holidays);
        }
    }
}
