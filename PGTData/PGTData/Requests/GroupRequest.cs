﻿using PGTData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Requests
{
    public class GroupRequest
    {
        public string GroupName { get; set; }
        public string GroupCourse { get; set; }
        public int CampusID { get; set; }
    }
}
