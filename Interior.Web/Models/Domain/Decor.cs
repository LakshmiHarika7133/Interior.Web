namespace Interior.Web.Models.Domain
{
    public class Decor
    {
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
        public string ImageUrl { get; set; }
        public string UrlHandle { get; set; }
        public DateTime PublishedDate { get; set; }
        public bool Visible { get; set;}

        public required ICollection<Tag> Tags { get; set; }
    }
}
