using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MYOBConsoleAPI.DAC
{
    public class Bill
    {
        public class Root
        {
            public string id { get; set; }
            public int rowNumber { get; set; }
            public Note note { get; set; }
            public Amount Amount { get; set; }
            public ApprovedForPayment ApprovedForPayment { get; set; }
            public Balance Balance { get; set; }
            public BranchID BranchID { get; set; }
            public CashAccount CashAccount { get; set; }
            public CurrencyID CurrencyID { get; set; }
            public Date Date { get; set; }
            public Description Description { get; set; }
            public List<Detail> Details { get; set; }
            public DueDate DueDate { get; set; }
            public Hold Hold { get; set; }
            public LastModifiedDateTime LastModifiedDateTime { get; set; }
            public LocationID LocationID { get; set; }
            public PostPeriod PostPeriod { get; set; }
            public ReferenceNbr ReferenceNbr { get; set; }
            public Status Status { get; set; }
            public TaxTotal TaxTotal { get; set; }
            public Terms Terms { get; set; }
            public Type Type { get; set; }
            public Vendor Vendor { get; set; }
            public VendorRef VendorRef { get; set; }
            public Custom custom { get; set; }
            public Links _links { get; set; }
        }

        public class Note
        {
            public string value { get; set; }
        }

        public class Amount
        {
            public double value { get; set; }
        }

        public class ApprovedForPayment
        {
            public bool value { get; set; }
        }

        public class Balance
        {
            public double value { get; set; }
        }

        public class BranchID
        {
            public string value { get; set; }
        }

        public class CashAccount
        {
            public string value { get; set; }
        }

        public class CurrencyID
        {
            public string value { get; set; }
        }

        public class Date
        {
            public DateTime value { get; set; }
        }

        public class Description
        {
            public string value { get; set; }
        }

        public class Detail
        {
            public string id { get; set; }
            public int rowNumber { get; set; }
            public Note note { get; set; }
            public Account Account { get; set; }
            public Amount Amount { get; set; }
            public Branch Branch { get; set; }
        }

        public class Account
        {
            public string value { get; set; }
        }

        public class Branch
        {
            public string value { get; set; }
        }

        public class DueDate
        {
            public DateTime value { get; set; }
        }

        public class Hold
        {
            public bool value { get; set; }
        }

        public class LastModifiedDateTime
        {
            public DateTime value { get; set; }
        }

        public class LocationID
        {
            public string value { get; set; }
        }

        public class PostPeriod
        {
            public string value { get; set; }
        }

        public class ReferenceNbr
        {
            public string value { get; set; }
        }

        public class Status
        {
            public string value { get; set; }
        }

        public class TaxTotal
        {
            public double value { get; set; }
        }

        public class Terms
        {
            public string value { get; set; }
        }

        public class Type
        {
            public string value { get; set; }
        }

        public class Vendor
        {
            public string value { get; set; }
        }

        public class VendorRef
        {
            public string value { get; set; }
        }

        public class Custom
        {
        }

        public class Links
        {
            public string self { get; set; }
            public string files_put { get; set; }
        }

        public static string BillExampleJSON()
        {
            Root root = new Root
            {
                Amount = new Amount { value = 23.4900 },
                ApprovedForPayment = new ApprovedForPayment { value = false },
                Balance = new Balance { value = 0.0000 },
                BranchID = new BranchID { value = "MAIN" },
                CashAccount = new CashAccount { value = "11127" },
                CurrencyID = new CurrencyID { value = "AUD" },
                Date = new Date { value = DateTime.Parse("2024-02-28T00:00:00+00:00") },
                Description = new Description { value = "BUSHBY CLEANING" },
                Details = new List<Detail>
                {
                    new Detail
                    {
                        Account = new Account { value = "22001" },
                        Amount = new Amount { value = 23.4900 },
                        Branch = new Branch { value = "MAIN" }
                    }
                },
                DueDate = new DueDate { value = DateTime.Parse("2024-02-28T00:00:00+00:00") },
                Hold = new Hold { value = false },
                LocationID = new LocationID { value = "MAIN" },
                PostPeriod = new PostPeriod { value = "082024" },
                TaxTotal = new TaxTotal { value = 0.0000 },
                Terms = new Terms { value = "CASHONLY" },
                Type = new Type { value = "Bill" },
                Vendor = new Vendor { value = "13" },
                //VendorRef = new VendorRef { value = "13" }
                VendorRef = new VendorRef { value = DateTime.Now.ToString() } // has to be unique
            };
            return JsonConvert.SerializeObject(root);
        }
    }
}

