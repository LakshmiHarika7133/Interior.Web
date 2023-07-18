namespace Interior.Web.Models.Domain
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string TypeName { get; set; }

        public required ICollection<Decor> Decors { get; set; }
    }
}
