using System;
using System.Collections.Generic;
using System.Linq;

namespace AsrAccounting.Model.Entity {
    /// <summary>
    /// Entity to store invoice information
    /// </summary>
    public class Invoice {

        /// <summary>
        /// Unique id of the invoice
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Title of the current invoice
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Date of the current invoice
        /// </summary>
        public DateTime InvoiceDate { get; set; }

        /// <summary>
        /// Stores the customer information of the current invoice
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// The total amount without VAT
        /// </summary>
        public decimal TotalAmountNet { get; set; }

        /// <summary>
        /// The total amount inclusive VAT
        /// </summary>
        public decimal TotalAmountGross { get; set; }

        /// <summary>
        /// The total VAT amount
        /// </summary>
        public decimal TotalAmountVat { get; set; }

        /// <summary>
        /// A set of all related invoice lines
        /// </summary>
        public List<InvoiceLine> InvoiceLines { get; set; }
        
        /// <summary>
        /// Basic contructor which initializes an empty invoice line list
        /// </summary>
        public Invoice() {
            InvoiceLines = new List<InvoiceLine>();
        }

        /// <summary>
        /// Method to add an invoice line
        /// </summary>
        /// <param name="invoiceLine">An invoice line object you want to add to list</param>
        public void AddInvoiceLine(InvoiceLine invoiceLine) {
            InvoiceLines.Add(invoiceLine);
        }

        /// <summary>
        /// Method to remove an invoice line
        /// </summary>
        /// <param name="invoiceLine">An invoice line object you want to remove from list</param>
        public void RemoveInvoiceLine(InvoiceLine invoiceLine) {
            InvoiceLines.Remove(invoiceLine);
        }

        /// <summary>
        /// Function to retrieve the sum of TotalAmountNet values from the 
        /// invoice lines
        /// </summary>
        /// <returns>Sum of TotalAmountNet values</returns>
        public decimal GetTotalAmountNet() {
            if(InvoiceLines.Count > 0) {
                return (                    
                    from i in InvoiceLines
                    select i.LineAmountNet
                ).Sum();
            } else {
                return 0;
            }
        }

        /// <summary>
        /// Function to retrieve the sum of TotalAmountGross values from the 
        /// invoice lines
        /// </summary>
        /// <returns>Sum of TotalAmountNet values</returns>
        public decimal GetTotalAmountGross() {
            if(InvoiceLines.Count > 0) {
                return (
                    from i in InvoiceLines
                    select i.LineAmountGross
                ).Sum();
            } else {
                return 0;
            }
        }
    }
}
