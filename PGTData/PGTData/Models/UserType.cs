using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Models
{
    public class UserType
    {
        [Column("UserID")]
        public int UserID { get; set; }
        public User User { get; set; }

        [Column("GroupID")]
        public int GroupID { get; set; }
        public Group Group { get; set; }

        public string UserTypeDescription { get; set; }
    }
}
