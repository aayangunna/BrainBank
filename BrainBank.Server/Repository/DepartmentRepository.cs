using BrainBank.Server.Models;
using BrainBank.Shared;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BrainBank.Server.Repository
{
    
    
        public class DepartmentRepository : IDepartmentRepository
        {
            private readonly AppDbContext appDbContext;

            public DepartmentRepository(AppDbContext appDbContext)
            {
                this.appDbContext = appDbContext;
            }

            public async Task<Department> GetDepartment(int departmentId)
            {
                return await appDbContext.Departments
                    .FirstOrDefaultAsync(d => d.DepartmentId == departmentId);
            }

            public async Task<IEnumerable<Department>> GetDepartments()
            {
                return await appDbContext.Departments.ToListAsync();
            }
        }
 
}
