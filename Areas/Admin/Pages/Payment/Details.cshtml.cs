using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Markatooo.Data;
using Markatooo.Models;
using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;

namespace Markatooo.Areas.Admin.Pages.Payment
{
    public class DetailsModel : PageModel
    {
        private readonly MarkatoooContext context;

        public DetailsModel(MarkatoooContext _context)
        {
            context = _context;
        }
        public PaymentModel payment { get; set; }
        public string URL { get; set; }
        public string QRScan { get; set; }
        public bool deactivelink { get; set; }
        public Models.Gateway Gateway { get; set; }
        public void OnGet(int paymentid)
        {
        URL = "https://markatooo.beintrackpay.com/Pay?TransactionId=" + paymentid;
            //URL = "https://localhost:44354/Pay?TransactionId=" + paymentid;
            QRCodeGenerator QrGenerator = new QRCodeGenerator();
            QRCodeData QrCodeInfo = QrGenerator.CreateQrCode(URL, QRCodeGenerator.ECCLevel.Q);
            QRCode QrCode = new QRCode(QrCodeInfo);
            Bitmap QrBitmap = QrCode.GetGraphic(60);
            byte[] BitmapArray = QrBitmap.BitmapToByteArray();
            QRScan = string.Format("data:image/png;base64,{0}", Convert.ToBase64String(BitmapArray));
            payment = context.Payments.FirstOrDefault(a => a.PaymentModelId == paymentid);
            Gateway = context.Gateways.FirstOrDefault(a=>a.GateWayId==payment.GateWayId);
        }
       
        }

    }

