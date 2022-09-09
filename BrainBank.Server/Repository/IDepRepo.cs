using BrainBank.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BrainBank.Server.Repository
{
    public interface IDepRepo
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(int departmentId);
    }
}

