using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Markatooo.Data;
using Markatooo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Markatooo.Pages
{
    public class TransactionStatusModel : PageModel
    {
        private MarkatoooContext _context;
        public PaymentModel payment { get; set; }
        public bool issuccess { get; set; }
        public TransactionStatusModel(MarkatoooContext context)
        {
            _context = context;

        }
        public IActionResult OnGet(int transactionId)
        {
            try
            {
                payment = _context.Payments.FirstOrDefault(e => e.PaymentModelId == transactionId);
                return Page();
            }
            catch(Exception e)
            {
                return RedirectToPage("SomethingwentError");
            }



        }
    }
}
