using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using monitorapplication.Data;
using monitorapplication.Models;

namespace monitorapplication.Pages
{
    public class IndexModel : PageModel
    {

        private readonly AppDbContext _db;

        public IndexModel(AppDbContext db)
        {
            _db = db;
        }

        public List<Product>? Products { get; set; }

       
        public async Task OnGetAsync()
        {
            Products = await _db.Products.ToListAsync();
        }
    }
}
