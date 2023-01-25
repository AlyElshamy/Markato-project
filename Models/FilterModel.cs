using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Markatooo.Models
{
    public class FilterModel
    {
        public string radio { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? OnDay { get; set; }

        public DateTime? ToDate { get; set; }
        public int? GateID { get; set; }
        public int? PaymentSatusId { get; set; }

        public bool all { get; set; }
        public bool allGateways { get; set; }
        public bool allTransactions { get; set; }

        public string Date { get; set; }

    }
}
