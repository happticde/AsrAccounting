using System;
using System.Collections.Generic;

namespace AsrAccounting.Model.Entity {
    public class AsrOrder {
        private int id;
        private string title;
        private DateTime orderDate;
        private AsrCustomer customer;
        private List<AsrOrderLine> orderLines;
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

        public List<AsrOrderLine> OrderLines {
            get {
                return orderLines;
            }

            set {
                orderLines = value;
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

        public DateTime OrderDate {
            get {
                return orderDate;
            }

            set {
                orderDate = value;
            }
        }
    }
}
