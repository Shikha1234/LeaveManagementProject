using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace HR.LeaveManagement.Persistance.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly LeaveManagementDbContext _dbContext;

        public LeaveRequestRepository(LeaveManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public Task ChangeApprovalStatus(LeaveRequest leaveRequest, bool? ApprovalStatus)
        {
            leaveRequest.Approved = ApprovalStatus;
            _dbContext.Entry(leaveRequest).State = EntityState.Modified;
            return _dbContext.SaveChangesAsync();
        }

        public async Task<LeaveRequest> GetAllLeaveRequestWithDetails(int id)
        {
            var leaveRequest = await _dbContext.LeaveRequests
                .Include(x => x.LeaveTypeId)
                .FirstOrDefaultAsync(q => q.Id == id);

            return leaveRequest;
        }

        public async Task<List<LeaveRequest>> GetAllLeaveRequestWithDetails()
        {
            var leaveRequest = await _dbContext.LeaveRequests
                .Include(q => q.LeaveTypeId)
                .ToListAsync();

            return leaveRequest;
        }
    }
}
