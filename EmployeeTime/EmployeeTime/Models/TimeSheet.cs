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

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [DataType(DataType.Time)]
        public DateTime TimeIn { get; set; }

        [DataType(DataType.Time)]
        public DateTime TimeOut { get; set; }

        public int DailyHours { get; set; }

        public virtual Employee Employee { get; set; }
    }
}