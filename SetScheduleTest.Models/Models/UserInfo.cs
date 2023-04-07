using System;
using System.Collections.Generic;
using System.Text;

namespace SetScheduleTest.Models.Models
{
    public partial class UserInfo
    {
        public int Id { get; set; }
        public string Hobby { get; set; }
        public string Location { get; set; }
        public double Distance { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
    }
}
