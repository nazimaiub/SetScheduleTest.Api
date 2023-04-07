using Microsoft.EntityFrameworkCore;
using SetScheduleTest.Models.Mappings;
using SetScheduleTest.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SetScheduleTest.Models.Context
{
    public class SetSchedule_Test_DBContext : DbContext
    {
        public SetSchedule_Test_DBContext()
        {
        }
        public SetSchedule_Test_DBContext(DbContextOptions<SetSchedule_Test_DBContext> options) : base(options)
        {

        }

        public virtual DbSet<UserInfo> UserInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new USER_INFO());
            base.OnModelCreating(modelBuilder);
        }
    }
}
