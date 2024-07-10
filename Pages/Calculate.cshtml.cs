using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TipCalculator.Models;

namespace TipCalculator.Pages
{
    public class CalculateModel : PageModel
    {
        [BindProperty]
        public TipCalculatorModel TipCalculator { get; set; }//getting the data from the model (in other words is declaring an instance in this class that gets data from the model

        public decimal Tip10 { get; set; }
        public decimal Tip15 { get; set; }
        public decimal Tip20 { get; set; }

        public void OnGet()
        {
            TipCalculator = new TipCalculatorModel();// thi is returned when the page is first requested
        }

        public void OnPost()//called  on sub-mission of the form
        {
            if (ModelState.IsValid)
            {
                Tip10 = TipCalculator.CalculateTip(10);
                Tip15 = TipCalculator.CalculateTip(15);
                Tip20 = TipCalculator.CalculateTip(20);
            }
            else
            {
                Tip10 = 0;
                Tip15 = 0;
                Tip20 = 0;
            }
        }
    }
}
