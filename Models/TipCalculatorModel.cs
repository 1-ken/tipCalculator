using System.ComponentModel.DataAnnotations;

namespace TipCalculator.Models
{
    public class TipCalculatorModel //name of the model
    {
        [Required(ErrorMessage = "Please enter the cost of the meal.")]//validation
        [Range(0.01, double.MaxValue, ErrorMessage = "The cost must be greater than zero.")] //validation
        public decimal MealCost { get; set; } //property

        public decimal CalculateTip(decimal percentage)
        {
            return MealCost * percentage / 100;
        }
    }
}
