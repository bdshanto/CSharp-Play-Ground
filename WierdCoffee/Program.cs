using WierdCoffee.Models;
using WierdCoffee.Policies;

namespace WierdCoffee;

class Program
{
    static void Main(string[] args)
    {
        var employeeRepository = new GenericRepositoryRemove<Employee>();
        AddEmployee(employeeRepository);
        GetEmployeeById(employeeRepository);
        employeeRepository.Save();
        
        var orgRepository = new GenericRepositoryRemove<Organization>();
        AddOrganizations(orgRepository);
        GetOrganizationById(orgRepository);
        orgRepository.Save();


        Console.ReadLine();
    }

    private static void GetOrganizationById(GenericRepositoryRemove<Organization> orgRepository)
    {
        var org = orgRepository.GetById(2);
        Console.WriteLine($"Get Organization Id: "+org);
    }

    private static void GetEmployeeById(GenericRepositoryRemove<Employee> employee)
    {
        var emp = employee.GetById(4);
        Console.WriteLine($"Get Employee By Id: "+emp);
    }


    private static void AddEmployee(GenericRepository<Employee> employeeRepository)
    {
        employeeRepository.Add(new Employee(){Id = 1, FirstName = "Tamim I."});
        employeeRepository.Add(new Employee(){Id = 2, FirstName = "Imrul K."});
        employeeRepository.Add(new Employee(){Id = 3, FirstName = "M. Ashraful"});
        employeeRepository.Add(new Employee(){Id = 4, FirstName = "Sakib Al Hasan"});
    }

    private static void AddOrganizations(GenericRepository<Organization> orgRepository)
    {
        orgRepository.Add(new Organization(){Id = 1, Name = "AITS"});
        orgRepository.Add(new Organization(){Id = 2, Name = "BCB"});
        orgRepository.Add(new Organization(){Id = 3, Name = "Shakib's"});
        orgRepository.Add(new Organization(){Id = 4, Name = "DUET"});
        orgRepository.Add(new Organization(){Id = 4, Name = "MIST"});
    }
}