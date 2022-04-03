using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.DTOs.LeaveRequest
{
    internal class LeaveRequestListDto
    {
        public LeaveTypeDto LeaveType { get; set; }

        public DateTime DateRequested { get; set; }

        public bool? Approved { get; set; }
    }
}
 