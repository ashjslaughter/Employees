using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeTime.Models
{
    public class TimeSheet
    {
        public int TimeSheetID { get; set; }
        public DateTime Date { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime DailyHours { get; set; }

        public virtual Employee Employee { get; set; }
    }
}