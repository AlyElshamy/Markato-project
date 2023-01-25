using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using Markatooo.Data;
using Markatooo.Models;

namespace Markatooo.Areas.Admin.Pages.Payment
{
    public class DeletedPaymentModel : PageModel
    {
        private readonly MarkatoooContext context;
        public double totalgen { get; set; }
        public double totalRecived { get; set; }
        public double Net { get; set; }
        public List<PaymentModel> payment { get; set; }
        public IToastNotification ToastNotification { get; }

        public DeletedPaymentModel(MarkatoooContext _context, IToastNotification toastNotification)
        {
            context = _context;
            ToastNotification = toastNotification;
        }
        public void OnGet()
        {
            payment = context.Payments.Where(a => a.Active == false).ToList();

        }
        public IActionResult OnPost(int id)
        {
            var payment = context.Payments.Find(id);
            payment.Active = true;
            context.Attach(payment).State = EntityState.Modified;
            context.SaveChanges();
            ToastNotification.AddSuccessToastMessage("Payment Retrieved successfully...");
            return Page();
        }
    }
}
