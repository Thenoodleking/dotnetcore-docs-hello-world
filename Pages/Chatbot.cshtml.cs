using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LSP_HOME.Pages
{
    public class ChatbotModel : PageModel
    {
        [BindProperty]
        public string Prompt { get; set; }

        [BindProperty]
        public string Text { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            // Handle form submission here
        }
    }
}
