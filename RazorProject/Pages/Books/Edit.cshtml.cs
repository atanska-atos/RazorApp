using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorProject.Data;
using RazorProject.Models.ViewModels;

namespace RazorProject.Pages.Books
{
    public class EditModel : PageModel
    {
        private readonly RazorAppDbContext dbContext;
        public EditBookViewModel EditBookViewModel { get; set; }
        public EditModel(RazorAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }



        public void OnGet(Guid id)
        {
            var book = dbContext.Books.Find(id);

            if (book == null)
            {
                // Convert Domain Model to View Model
                EditBookViewModel = new EditBookViewModel()
                {
                    Title = book.Title,
                    Author = book.Author,
                    Price = book.Price,
                    ReleaseDate = book.ReleaseDate,
                    Description = book.Description
                };
            }
        }

        public void OnPost()
        {
            if (EditBookViewModel != null)
            {
                var existingBook = dbContext.Books.Find(EditBookViewModel.Id);

                if (existingBook != null)
                {
                    existingBook.Title = EditBookViewModel.Title;
                    existingBook.Author = EditBookViewModel.Author;
                    existingBook.Price = EditBookViewModel.Price;
                    existingBook.ReleaseDate = EditBookViewModel.ReleaseDate;
                    existingBook.Description = EditBookViewModel.Description;

                    dbContext.SaveChanges(); 
                    ViewData["Message"] = "Employee updated successfully";
                }
            }

            


        }
    }
}
