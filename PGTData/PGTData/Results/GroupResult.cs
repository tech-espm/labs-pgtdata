using PGTData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Results
{
    public class GroupResult
    {
        public int GroupID { get; set; }
        public string GroupName { get; set; }
        public string GroupCourse { get; set; }

        public static explicit operator GroupResult(Group obj)
        {
            GroupResult convertedObject = new GroupResult
            {
                GroupID = obj.GroupID,
                GroupName = obj.GroupName,
                GroupCourse = obj.GroupCourse
            };

            return convertedObject;
        }
    }
}
