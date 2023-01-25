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
    public class ListModel : PageModel
    {
        private readonly MarkatoooContext context;
        public IToastNotification ToastNotification { get; }
        [BindProperty]
        public Models.Gateway gateway { get; set; }
        public List<PaymentModel> Payments = new List<PaymentModel>();
        public List<string> estimatedates = new List<string>();
        public ListModel(MarkatoooContext _context, IToastNotification toastNotification)
        {
            context = _context;
            ToastNotification = toastNotification;

        }
        public void OnGet()
        {
            Payments = context.Payments.Include(a => a.Gateway).Include(a => a.PaymentStatus).OrderByDescending(a => a.TransactionDate).Select(a => new PaymentModel
            {
                PaymentModelId = a.PaymentModelId,
                Gateway = a.Gateway,
                Amout = a.Amout,
                Email = a.Email,
                FirstName = a.FirstName,
                LastName = a.LastName,
                OrderNumber = a.OrderNumber,
                PhoneNumber = a.PhoneNumber,
                PaymentStatusId = a.PaymentStatusId,
                TransactionDate = a.TransactionDate,
            }).ToList();



            foreach (var item in Payments.Where(e => e.PaymentStatusId == 1))
            {
                if (item.TransactionDate.AddHours(24) <= DateTime.Now)
                {

                    item.PaymentStatusId = 4;
                    item.Active = false;

                    context.Attach(item).State = EntityState.Modified;

                }
                else
                    item.estimatedtime = item.TransactionDate.AddDays(1).Subtract(DateTime.Now).ToString(@"hh\:mm");
            }
        
            context.SaveChanges();

            //foreach (var item in Payments  )
            //{
            //    if (item.TransactionDate.AddHours(24) <= DateTime.Now)
            //    {
            //        item.estimatedtime = TimeSpan.Zero.ToString(@"hh\:mm");
            //    }
            //    else
            //    item.estimatedtime = item.TransactionDate.AddDays(1).Subtract(DateTime.Now).ToString(@"hh\:mm");
            //}

        }

       
    }
}
