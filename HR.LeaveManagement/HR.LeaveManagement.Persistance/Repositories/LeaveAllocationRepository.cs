using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Application.Persistence;
using HR.LeaveManagement.Application.Persistence.Contracts;
using HR.LeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Persistance.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveType>, ILeaveAllocationRepository
    {
        private readonly LeaveManagementDbContext _dbContext;

        public LeaveAllocationRepository(LeaveManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<LeaveAllocation> Add(LeaveAllocation entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(LeaveAllocation entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<LeaveAllocation>> GetAllLeaveAllocationsWithDetails()
        {
            throw new NotImplementedException();
        }

        public Task<LeaveAllocation> GetLeaveAllocationWithDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(LeaveAllocation entity)
        {
            throw new NotImplementedException();
        }

        Task<LeaveAllocation> IGenericRepository<LeaveAllocation>.Get(int id)
        {
            throw new NotImplementedException();
        }

        Task<IReadOnlyList<LeaveAllocation>> IGenericRepository<LeaveAllocation>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
