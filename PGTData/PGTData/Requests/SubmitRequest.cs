namespace PGTData.Requests
{
    public class SubmitRequest
    {
        public int GroupID { get; set; }
        public string FilePath { get; set; }
        public string CommentDescription { get; set; }
        public int ReviewTypeID { get; set; }
    }
}