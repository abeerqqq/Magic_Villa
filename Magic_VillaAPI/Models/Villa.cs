namespace Magic_VillaAPI.Models
{
    public class Villa
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // we do not want the creation time to appear in the API
        public DateTime CreateAt { get; set; }
    }
}
