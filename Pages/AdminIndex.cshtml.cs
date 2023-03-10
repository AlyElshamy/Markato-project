using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Markatooo.Data;

namespace Markatooo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MarkatoooContext _context;
        public int revenues { get; set; }
        public int PaymentCount { get; set; }
        public double PaymentCost { get; set; }
        public double SuccessAmountCount { get; set; }
        public int ActivePaymentCount { get; set; }
        public int NotActivePaymentCount { get; set; }

        public double FailedAmountCount { get; set; }
        public IndexModel(MarkatoooContext context)
        {
            _context = context;
        }




        public void OnGet()
        {
            PaymentCount = _context.Payments.Where(e => e.TransactionDate.Date == DateTime.Now.Date).Count();
            PaymentCost = _context.Payments.Where(e => e.TransactionDate.Date == DateTime.Now.Date).Sum(e => e.Amout);
            PaymentCost = Math.Round(PaymentCost, 2);
            SuccessAmountCount = _context.Payments.Where(e => e.PaymentStatusId==2  && e.TransactionDate.Date == DateTime.Now.Date).Sum(e => e.Amout);
            SuccessAmountCount = Math.Round(SuccessAmountCount, 2);
            ActivePaymentCount = _context.Payments.Where(e => e.Active == true).Count();
            NotActivePaymentCount = _context.Payments.Where(e => e.Active == false).Count();
            FailedAmountCount = _context.Payments.Where(e => e.PaymentStatusId==3 && e.TransactionDate.Date == DateTime.Now.Date).Sum(e => e.Amout);
            FailedAmountCount = Math.Round(FailedAmountCount, 2);

        }
    }
}
