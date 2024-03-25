using EmployeeManagerConsoleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Employee Management System!!!");
        Console.WriteLine();
        Console.WriteLine("Enter your Full Name");
        string fullName = Console.ReadLine();
        Console.WriteLine("Enter your Email");
        string email = Console.ReadLine();
        Employee employee = new Employee { Name = fullName, Email = email};
        EmployeeRepository repository = new EmployeeRepository();
        repository.SaveEmployee(employee);
        Console.WriteLine("Employee saved successfully");
        Console.WriteLine("What is the Salary?");
        double salary = double.Parse(Console.ReadLine());
        double tax =  CalculateTax.calculateTax(salary);
        TaxRepository taxRepository = new TaxRepository();
        taxRepository.addToTaxScheme(employee, tax);
        Console.WriteLine("How many holidays for the employee");
        double holidayNum =  double.Parse(Console.ReadLine());
        CalculateHolidays calculateHolidays = new CalculateHolidays { Holidays = holidayNum };
        HolidayRepository holidayRepository = new HolidayRepository();
        holidayRepository.addHolidays(employee,calculateHolidays.getHolidays());

        Console.WriteLine();
        Console.WriteLine(employee.getEmployeeDetails());
      
   

    }
}