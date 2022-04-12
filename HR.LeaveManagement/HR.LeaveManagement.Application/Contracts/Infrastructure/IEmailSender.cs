using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Contracts.Infrastructure
{
    public class IEmailSender
    {
        Task<bool> SendEmail(Email email);
    }
}
