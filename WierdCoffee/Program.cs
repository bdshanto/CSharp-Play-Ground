using WierdCoffee.Models;
using WierdCoffee.Policies;

namespace WierdCoffee;

class Program
{
    static void Main(string[] args)
    {
        var employeeRepository = new GenericRepository<Employee>();
        AddEmployee(employeeRepository);
        RetriveEmployee(employeeRepository);
        
        var orgRepository = new GenericRepository<Organization>();
        AddOrganizations(orgRepository);
        RetriveOrganization(orgRepository);
    }

    private static void RetriveOrganization(GenericRepository<Organization> orgRepository)
    {
             
        int orgCount = 0;
        foreach (var organization in orgRepository.GetItems())
        {
            Console.WriteLine($"Organization: Id: {organization.Id} Name: {organization.Name}");
            ++orgCount;
        }

        Console.WriteLine($"Total Organizations: {orgCount}");

    }

    private static void RetriveEmployee(GenericRepository<Employee> employeeRepository)
    {
        int employeeCount = 0;
        foreach (var employee in employeeRepository.GetItems())
        {
            Console.WriteLine($"Employee Id: {employee.Id} Name: {employee.FirstName}");
            ++employeeCount;
        }
        Console.WriteLine($"Total Employee: {employeeCount}");
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