using Malone_Bulkley_CSU_dotNET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Malone_Bulkley_CSU_dotNET.Controllers
{
    public class BudgetDataController : Controller
    {
        private readonly Team106DBContext budgetContext;


        public BudgetDataController(Team106DBContext aContext)
        {
            budgetContext = aContext;
        }

        public IActionResult TableView()
        {
            var categoryAmounts = budgetContext.budget_lines.Include(p => p.category_name).Include(p => p.budgeted_amount).Include(p => p.actual_amount);

            return View(categoryAmounts.ToList());
        }

        public IActionResult ListView()
        {
            var budgetLines = budgetContext.budget_lines.OrderBy(p => p.category_name);

            return View(budgetLines.ToList());
        }

        public IActionResult SortView(string sortOrder)
        {
            ViewData["CategorySortParam"] = String.IsNullOrEmpty(sortOrder) ? "nameDesc" : "";

            ViewData["BudgetedAmountSortParam"] = (sortOrder == "amount") ? "budgetAmountDesc" : "amount";

            ViewData["ActualAmountSortParam"] = (sortOrder == "amount") ? "actualAmountDesc" : "amount";


            // define a LINQ query to retrieve all Products (using query syntax)

            var categories = from p in budgetContext.budget_lines orderby p.category_name select p;

            switch (sortOrder)
            {
                case "nameDesc":
                    categories = categories.OrderByDescending(p => p.category_name);
                    break;
                case "actualAmount":
                    categories = categories.OrderBy(p => p.actual_amount);
                    break;
                case "budgetedAmount":
                    categories = categories.OrderByDescending(p => p.budgeted_amount);
                    break;
            }

            return View(categories.ToList());
        }

        public IActionResult FilterView(string searchCategory)
        {

            ViewData["CategoryFilter"] = searchCategory;

            var categories = from p in budgetContext.budget_lines select p;

            // depending on the filter values (received as parameters from the query string in the URL), where methods are used to filter the IQueryable object, products

            if (!String.IsNullOrEmpty(searchCategory))
            {
                categories = categories.Where(p => p.category_name.Contains(searchCategory));
            }

            return View(categories.OrderBy(p => p.category_name).ToList());
        }
    }
}
