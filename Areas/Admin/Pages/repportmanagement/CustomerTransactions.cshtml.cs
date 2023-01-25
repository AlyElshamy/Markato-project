using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Markatooo.Data;
using Markatooo.Models;

namespace Markatooo.Areas.Admin.Pages.repportmanagement
{
    public class CustomerTransactionsModel : PageModel
    {
        private readonly MarkatoooContext context;
        public UserManager<ApplicationUser> UserManager { get; }

        public List<PaymentModel> Transactions { get; set; }
        public CustomerTransactionsModel(MarkatoooContext context, UserManager<ApplicationUser> userManager)
        {
            UserManager = userManager;

            this.context = context;
        }
        public async Task<IActionResult> OnGetAsync()
        {
            var user = await UserManager.GetUserAsync(User);
            Transactions = context.Payments.Where(e=>e.Userid== user.Id)
                                  .ToList();
            return Page();
        }
    }
}
