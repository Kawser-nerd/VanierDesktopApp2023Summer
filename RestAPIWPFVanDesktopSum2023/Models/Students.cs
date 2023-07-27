namespace RestAPIWPFVanDesktopSum2023.Models
{
    public class Students
    {
        /*
         * this class holds all the entries in your dataset. So, it holds all the columns
         * present in the remote data server
         */
        public string name { get; set; }
        public int id { get; set; }
        public string email { get; set; }
        public string term { get; set; }
    }
}
