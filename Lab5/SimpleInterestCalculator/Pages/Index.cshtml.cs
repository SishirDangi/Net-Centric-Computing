using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SimpleInterestCalculator.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPost(double principal, double rate, double time)
        {
            double interest = (principal * rate * time) / 100;
            ViewData["Interest"] = interest;
            return RedirectToPage("Result", new { interest });
        }
    }
}
