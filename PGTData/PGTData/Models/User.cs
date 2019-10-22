using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public int UserRegister { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public int CampusID { get; set; }

        [Column("UserTypeID")]
        public int UserTypeID { get; set; }
        public UserType UserType { get; set; }

        [Column("GroupID")]
        public int GroupID { get; set; }
        public Group Group { get; set; }

        public List<Warning> Warnings { get; set; }
        
        public List<Review> Reviews { get; set; }
    }
}
