using System;
using System.Collections.Generic;

namespace AsrAccounting.Model.Entity {
    public class AsrInvoice {
        private int id;
        private string title;
        private DateTime invoiceDate;
        private AsrCustomer customer;
        private List<AsrInvoiceLine> invoiceLines;
        private double totalNetAmount;
        private double totalVatAmount;
        private double totalGrossAmount;

        public int Id {
            get {
                return id;
            }

            set {
                id = value;
            }
        }

        public AsrCustomer Customer {
            get {
                return customer;
            }

            set {
                customer = value;
            }
        }

        public List<AsrInvoiceLine> OrderLines {
            get {
                return invoiceLines;
            }

            set {
                invoiceLines = value;
            }
        }

        public double TotalNetAmount {
            get {
                return totalNetAmount;
            }

            set {
                totalNetAmount = value;
            }
        }

        public double TotalVatAmount {
            get {
                return totalVatAmount;
            }

            set {
                totalVatAmount = value;
            }
        }

        public double TotalGrossAmount {
            get {
                return totalGrossAmount;
            }

            set {
                totalGrossAmount = value;
            }
        }

        public string Title {
            get {
                return title;
            }

            set {
                title = value;
            }
        }

        public DateTime InvoiceDate {
            get {
                return invoiceDate;
            }

            set {
                invoiceDate = value;
            }
        }
    }
}
