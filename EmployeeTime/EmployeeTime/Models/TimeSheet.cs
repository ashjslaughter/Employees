using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeTime.Models
{
    public class TimeSheet
    {
        public int TimeSheetId { get; set; }
        public DateTime Date { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }
        public DateTime DailyHours { get; set; }

        public virtual Employee Employee { get; set; }
    }
}