using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Pages.Tasks
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly WebApp.Data.Context _context;

        public IndexModel(WebApp.Data.Context context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Item != null)
            {
                Item = await _context.Item.ToListAsync();
            }
        }
    }
}