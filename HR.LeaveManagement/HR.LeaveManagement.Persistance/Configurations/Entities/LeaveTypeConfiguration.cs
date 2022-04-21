using HR.LeaveManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Persistance.Configurations.Entities
{
    public class LeaveTypeConfiguration : IEntityTypeConfiguration<LeaveType>
    {
        public void Configure(EntityTypeBuilder<LeaveType> builder)
        {
            builder.HasData(
                new LeaveType
                {
                    Id = 1,
                    DefaultDays = 10,
                    Name = "Vacation",
                    LastModifiedBy = "Sp",
                    CreatedBy = "SP",
                    DateCreated = DateTime.Now,
                    LastModifiedDate = DateTime.Now

                },
                new LeaveType
                {
                    Id = 2,
                    DefaultDays = 12,
                    Name = "Sick",
                    LastModifiedBy = "Sp1",
                    CreatedBy = "SP1",
                    DateCreated = DateTime.Now,
                    LastModifiedDate = DateTime.Now
                }
             );
        }
    }
}
