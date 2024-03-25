using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerConsoleApp
{
    public class MailingGroup
    {
        List<Employee> mailingGroupMembers;
        public MailingGroup() {
            mailingGroupMembers = new List<Employee>();

        }
    
        public void addEmployeeToMailingGroup(Employee employee)
        {
            mailingGroupMembers.Add(employee);
        }
    }
}
