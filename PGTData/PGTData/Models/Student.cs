using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int StudentRA { get; set; }

        [Column("GroupID")]
        public int GroupID { get; set; }
        public Group Group { get; set; }
    }
}
