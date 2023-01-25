using Markatooo.Data;
using Markatooo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Markatooo.Entities;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Net.Http;

namespace Markatooo.Controllers
{
    [Route("api/[Controller]/[action]")]

    public class IntegrationController : Controller
    {
        private readonly MarkatoooContext _context;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _db;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IWebHostEnvironment _hostEnvironment;
        public HttpClient httpClient { get; set; }
        public IntegrationController(MarkatoooContext context, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager,
            ApplicationDbContext db, RoleManager<IdentityRole> roleManager, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
            _db = db;
            _roleManager = roleManager;
            _hostEnvironment = hostEnvironment;
            httpClient = new HttpClient();

        }

        [HttpPost]
        public async Task<IActionResult> CreateRequest([FromBody] ViewModel.PaymentVm model, IFormFile file)
        {
            if (model != null)
            {
                try
                {
                    if (file != null)
                    {
                        string folder = "Attachment/";
                        model.Attachment = await UploadImage(folder, file);
                    }
                    var payments = _context.Payments.Include(a => a.PaymentStatus).Where(a => a.PaymentStatusId == 2).Select(a => a.OrderNumber).ToList();
                    if (payments.Contains(model.OrderNumber) == true)
                    {
                        return Ok(new { Status = "false", Message = "order number exists..." });

                    }
                    model.Active = true;
                    //model.issuccess = false;
                    model.PaymentStatusId = 1;
                    model.TransactionDate = DateTime.Now;
                    var paymentobj = new PaymentModel
                    {
                        Active = model.Active,
                        Amout = model.Amout,
                        Email = model.Email,
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        PhoneNumber = model.PhoneNumber,
                        GateWayId = model.GateWayId,
                        OrderNumber = model.OrderNumber,
                        Attachment = model.Attachment,

                        PaymentStatusId = model.PaymentStatusId,
                        PaymentModelId = model.PaymentModelId,
                        Remarks = model.Remarks,
                        TransactionDate = model.TransactionDate

                    };
                    // model.estimatedtime = DateTime.Now.AddDays(1);
                    _context.Payments.Add(paymentobj);
                    _context.SaveChanges();
                    return Ok(new { Status = "true", paymenturl = "https://markatooo.beintrackpay.com/Pay?paymentid=" + paymentobj.PaymentModelId });


                }
                catch (Exception e)
                {
                    return Ok(new { Status = false, Message = e.Message });
                }
            }
            return Ok(new { Status = "false", Message = "Something went wrong" });
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        private async Task<string> UploadImage(string folderPath, IFormFile file)
        {

            folderPath += Guid.NewGuid().ToString() + "_" + file.FileName;

            string serverFolder = Path.Combine(_hostEnvironment.WebRootPath, folderPath);

            await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));

            return folderPath;
        }


    }
}


