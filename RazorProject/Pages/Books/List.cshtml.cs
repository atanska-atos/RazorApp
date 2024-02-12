using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorProject.Data;
using System.Security.Principal;

namespace RazorProject.Pages.Books
{
    public class ListModel : PageModel
    {
        private readonly RazorAppDbContext dbContext;
        public List<Models.Domain.Book> Books { get; set; }

        public ListModel(RazorAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }



        public void OnGet()
        {
            Books = dbContext.Books.ToList();
        }
    }
}
