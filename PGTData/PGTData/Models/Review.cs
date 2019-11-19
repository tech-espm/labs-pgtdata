using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int ReviewContent { get; set; }
        public int ReviewRelevance { get; set; }
        public int ReviewResearch { get; set; }
        public int ReviewMemorial { get; set; }
        public int ReviewAccording { get; set; }
        
        public DateTime ReviewDate { get; set; }

        [Column("FileID")]
        public int FileID { get; set; }
        public File File { get; set; }

        [Column("ReviewTypeID")]
        public int ReviewTypeID { get; set; }
        public ReviewType ReviewType { get; set; }

        [Column("UserID")]
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
