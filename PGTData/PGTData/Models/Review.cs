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
        public string ReviewContent { get; set; }
        public string ReviewRelevance { get; set; }
        public string ReviewResearch { get; set; }
        public string ReviewMemorial { get; set; }
        public string ReviewAccording { get; set; }
        
        public DateTime ReviewDate { get; set; }

        [Column("FileID")]
        public int FileID { get; set; }
        public File File { get; set; }

        [Column("ReviewTypeID")]
        public int ReviewTypeID { get; set; }
        public ReviewType ReviewType { get; set; }

    }
}
