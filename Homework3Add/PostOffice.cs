using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3Add
{
    public class PostOffice
    {
        public List<Employee> Employees { get; } = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void Poll() 
        {
            foreach (Employee employee in Employees)
            {
                if (employee is Postman postman) 
                {
                    Console.WriteLine($"Имя:{postman.Name}. Статус: {postman.IsBusy}. Обязанности: {postman.OfficialDuties()}.");
                    continue;
                }

                Console.WriteLine($"Имя:{employee.Name}. Статус: {employee.IsBusy}. Обязанности: {employee.OfficialDuties()}." );
            }
        }
    }
}
