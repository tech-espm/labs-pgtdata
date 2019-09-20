using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        //FK public int UserID
        //FK public int FileID
        public string ReviewContent { get; set; }
        public string ReviewRelevance { get; set; }
        public string ReviewResearch { get; set; }
        public string ReviewMemorial { get; set; }
        public string ReviewAccording { get; set; }
        //FK public int ReviewTypeID
        public DateTime ReviewDate { get; set; }

        [Column("UserID")]
        public int UserID { get; set; }
        public User User { get; set; }

        [Column("FileID")]
        public int FileID { get; set; }
        public File File { get; set; }

        [Column("ReviewTypeID")]
        public int ReviewTypeID { get; set; }
        public ReviewType ReviewType { get; set; }

    }
}
