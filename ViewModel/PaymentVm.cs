using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Markatooo.ViewModel
{
    public class PaymentVm
    {
        public int PaymentModelId { get; set; }
        public double Amout { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int GateWayId { get; set; }
        public string OrderNumber { get; set; }
        public string Attachment { get; set; }
        public bool Active { get; set; }
        public int? PaymentStatusId { get; set; }
        public string Remarks { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
