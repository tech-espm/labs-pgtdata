using PGTData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Results
{
    public class StudentResult
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int StudentRA { get; set; }
        
        public int GroupID { get; set; }

        public static explicit operator StudentResult(Student obj)
        {
            StudentResult convertedObject = new StudentResult
            {
                StudentID = obj.StudentID,
                StudentName = obj.StudentName,
                StudentRA = obj.StudentRA,
                GroupID = obj.GroupID
            };

            return convertedObject;
        }
    }
}
