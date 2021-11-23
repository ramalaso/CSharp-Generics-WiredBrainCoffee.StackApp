using System;
using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Entities.Repositories;

namespace WiredBrainCoffee.StorageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new GenericRepository<Employee>();
            employeeRepository.Add(new Employee { FirstName = "Julia" });
            employeeRepository.Add(new Employee { FirstName = "Raul" });
            employeeRepository.Add(new Employee { FirstName = "Estefania" });
            employeeRepository.Add(new Employee { FirstName = "Luz" });
            employeeRepository.Save();

        }
    }
}
