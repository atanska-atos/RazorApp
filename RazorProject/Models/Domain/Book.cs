namespace RazorProject.Models.Domain
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }    
        public string Author { get; set; } 
        public long Price { get; set; }
        public DateTime ReleaseDate { get; set; } 
        public string Description { get; set; }
    }
}
