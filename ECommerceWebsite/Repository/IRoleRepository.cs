using ECommerceWebsite.Models;

namespace ECommerceWebsite.Repository
{
    public interface IRoleRepository
    {
        IEnumerable<Role> GetAllRoles();
        Role GetRoleById(int id);
        int AddRole(Role role);
        int UpdateRole(Role role);
        int DeleteRole(int id);

    }
}

