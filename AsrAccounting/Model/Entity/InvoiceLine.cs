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
        public int Quantity { get; set; }

        /// <summary>
        /// Single unit price of the line
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Sum amount of the line
        /// </summary>
        public decimal LineAmount { get; set; }
    }
}
