using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string CommentDescription { get; set; }

        [Column("ReviewID")]
        public int ReviewID { get; set; }
        public Review Review { get; set; }

    }
}

