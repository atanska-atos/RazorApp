using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorProject.Data;
using RazorProject.Models.Domain;
using RazorProject.Models.ViewModels;

namespace RazorProject.Pages.Books
{
    public class AddBookModel : PageModel
    {
        private readonly RazorAppDbContext dbContext;

        public AddBookModel(RazorAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        [BindProperty]
        public AddBookViewModel AddBookRequest { get; set; }
        public void OnGet()
        {
        }

        public void OnPost() 
        {
            var bookDomainModel = new Book
            {
                Title = AddBookRequest.Title,
                Author = AddBookRequest.Author,
                Price = AddBookRequest.Price,
                ReleaseDate = AddBookRequest.ReleaseDate,
                Description = AddBookRequest.Description
            };

            dbContext.Books.Add(bookDomainModel);
            dbContext.SaveChanges();

            ViewData["Message"] = "Employee created succesfully!";

        }
    }
}
