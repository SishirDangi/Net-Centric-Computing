using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SimpleInterestCalculator.Pages
{
    public class ResultModel : PageModel
    {
        public double Interest { get; set; }

        public void OnGet(double interest)
        {
            Interest = interest;
        }
    }
}
