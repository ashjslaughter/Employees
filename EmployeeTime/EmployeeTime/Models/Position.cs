﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeTime.Models
{
    public class Position
    {
        public int PositionID { get; set; }
        public string PositionTitle { get; set; }

        public virtual Department Department { get; set; }
    }
}