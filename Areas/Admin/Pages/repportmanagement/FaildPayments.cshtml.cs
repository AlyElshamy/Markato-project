using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Markatooo.Data;
using Markatooo.Models;
using Markatooo.Reports;

namespace Markatooo.Areas.Admin.Pages.repportmanagement
{
    public class FaildPaymentsModel : PageModel
    {
        private readonly MarkatoooContext context;

        [BindProperty]
        public rptsuccpayment Report { get; set; }
        public FaildPaymentsModel(MarkatoooContext context)
        {
            this.context = context;
        }
        public IActionResult OnGet()
        {
            List<PaymentModel> ds = context.Payments.Include(c=>c.Gateway).Where(a => a.issuccess == false).ToList();

            Report = new rptsuccpayment();
            Report.DataSource = ds;
            //Report.Parameters[0].Value = AssetId;
            //Report.RequestParameters = false;
            return Page();
        }
    }
}
