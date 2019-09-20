using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Models
{
    public class User
    {
        //public List<Professor_PGT> Professor_PGT { get; set; }
        //
        //[Column("GroupID")]
        //public int GroupID { get; set; }
        //public Group Group { get; set; }

        public int UserID { get; set; }
        public string UserName { get; set; }
        public int UserRegister { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }

        [Column("CampusID")]
        public int CampusID { get; set; }
        public Campus Campus { get; set; }

    }
}
