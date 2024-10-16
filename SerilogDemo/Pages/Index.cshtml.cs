using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SerilogDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogInformation("You requested the index page");

            try
            {
                throw new Exception("This is our demo exception");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "We caught this exception in the index Get call.");
            }
        }
    }
}
