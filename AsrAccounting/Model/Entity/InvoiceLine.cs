namespace AsrAccounting.Model.Entity {
    /// <summary>
    /// Entity for the an invoice line
    /// </summary>
    public class InvoiceLine {

        /// <summary>
        /// Unique Id of the invoice line
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Saves the detail of the invoice line
        /// </summary>
        public InvoiceLineDetail InvoiceLineDetail { get; set; }

        /// <summary>
        /// Quantity of the action
        /// </summary>
        public int Quantity { get; set; } = 1;

        /// <summary>
        /// Single unit price of the line
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Sum net amount of the invoice line
        /// </summary>
        public decimal LineAmountNet { get; set; }

        /// <summary>
        /// Sum gross amount of the invoice line
        /// </summary>
        public decimal LineAmountGross { get; set; }

        /// <summary>
        /// Sum VAT amount of the invoice line
        /// </summary>
        public decimal LineAmountVAT { get; set; }

        /// <summary>
        /// Value of VAT percentage
        /// </summary>
        public byte PercentageVAT { get; set; }

        private InvoiceLine(byte percentageVAT, decimal amountNet, decimal amountGross) {
            
        }

    }
}
