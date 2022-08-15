using WierdCoffee.Models;

namespace WierdCoffee.Policies;

public class OrganizationRepository : IRepository<Organization>
{
    private IList<Organization> Orginazations;

    public OrganizationRepository()
    {
        Orginazations =new  List<Organization>();
    }

    public void Add(Organization organization) => Orginazations.Add(organization);

    public IList<Organization> GetItems()
    {
        return Orginazations;
    }

   
}