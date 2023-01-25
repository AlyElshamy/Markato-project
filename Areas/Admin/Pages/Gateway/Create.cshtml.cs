using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NToastNotify;
using Markatooo.Data;

namespace Markatooo.Areas.Admin.Pages.Gateway
{
    public class CreateModel : PageModel
    {
        private readonly MarkatoooContext context;
        public IToastNotification ToastNotification { get; }
        public CreateModel(MarkatoooContext _context, IToastNotification toastNotification)
        {
            context = _context;
            ToastNotification = toastNotification;
        }



        public void OnGet()
        {
        }
        public IActionResult OnPost(Models.Gateway model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Not Valid");
                return Page();
            }
            try
            {
                context.Gateways.Add(model);
                context.SaveChanges();
                ToastNotification.AddSuccessToastMessage("GateWay added successfully..");

            }
            catch (Exception)
            {

                ToastNotification.AddErrorToastMessage("somthing went error..");
                return Page();
            }
            return RedirectToPage("list");
        }
    }
}
