using PGTData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGTData.Results
{
    public class ReviewResult
    {
        public int ReviewID { get; set; }
        public string ReviewContent { get; set; }
        public string ReviewRelevance { get; set; }
        public string ReviewResearch { get; set; }
        public string ReviewMemorial { get; set; }
        public string ReviewAccording { get; set; }

        public DateTime ReviewDate { get; set; }

        public int FileID { get; set; }

        public int ReviewTypeID { get; set; }

        public int UserID { get; set; }

        public static explicit operator ReviewResult(Review obj)
        {
            ReviewResult convertedObject = new ReviewResult
            {
                ReviewID = obj.ReviewID,
                ReviewContent = obj.ReviewContent,
                ReviewRelevance = obj.ReviewRelevance,
                ReviewResearch = obj.ReviewResearch,
                ReviewMemorial = obj.ReviewMemorial,
                ReviewAccording = obj.ReviewAccording,
                ReviewDate = obj.ReviewDate,
                FileID = obj.FileID,
                ReviewTypeID = obj.ReviewTypeID,
                UserID = obj.UserID
            };

            return convertedObject;
        }
    }
}
