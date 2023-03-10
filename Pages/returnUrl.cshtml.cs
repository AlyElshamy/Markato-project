    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Markatooo.Data;
using Markatooo.Models;

namespace Markatooo.Pages
{
    public class returnUrlModel : PageModel
    {
        private MarkatoooContext _context;
        public PaymentModel payment { get; set; }
        public bool issuccess { get; set; }
        public returnUrlModel(MarkatoooContext context)
        {
            _context = context;

        }
        public IActionResult OnGet(string orderId, string resultIndicator)
        {
            payment = _context.Payments.FirstOrDefault(e => e.OrderNumber == orderId);

            if (payment.successIndicator == resultIndicator)
            {
                payment.resultIndicator = resultIndicator;
                payment.PaymentStatusId = 2;
                issuccess = true;
                var UpdatedOrder = _context.Payments.Attach(payment);
                UpdatedOrder.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();

            }
            else
            {
                payment.resultIndicator = resultIndicator;
                payment.successIndicator = payment.successIndicator;
                payment.PaymentStatusId = 3;
                var UpdatedOrder = _context.Payments.Attach(payment);
                UpdatedOrder.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
            }

            return Page();
        }

    }
}
