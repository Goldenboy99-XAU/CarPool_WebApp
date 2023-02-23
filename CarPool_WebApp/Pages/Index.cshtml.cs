using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Web;


namespace CarPool_WebApp.Pages
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

        }
        protected void ContinueBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Login"); // replace with the URL of the page you want to redirect to
        }

    }
}