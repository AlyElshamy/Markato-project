using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Markatooo.Data;

namespace Markatooo.Areas.Admin.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MarkatoooContext _context;
        public int revenues { get; set; }
        public int PaymentCount { get; set; }
        public double PaymentCost { get; set; }
        public int SuccessAmountCount { get; set; }
        public int ActivePaymentCount { get; set; }
        public int NotActivePaymentCount { get; set; }

        public int FailedAmountCount { get; set; }
        public IndexModel(MarkatoooContext context)
        {
            _context = context;
        }
        

        

        public void OnGet()
        {
        }
    }
}
