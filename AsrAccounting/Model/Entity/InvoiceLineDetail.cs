namespace AsrAccounting.Model.Entity {
    /// <summary>
    /// Save reusable line details for repeating actions
    /// </summary>
    public class InvoiceLineDetail {
        /// <summary>
        /// Unique Id of the line detail
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Short description of the made action
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// A net amount which is filled by default
        /// </summary>
        public decimal DefaultAmountNet { get; set; }

        /// <summary>
        /// A gross amount which is filled by default
        /// </summary>
        public decimal DefaultAmountGross { get; set; }

        /// <summary>
        /// A VAT amount which is filled by default
        /// </summary>
        public decimal DefaultAmountVAT { get; set; }

        /// <summary>
        /// A default VAT percentage value
        /// </summary>
        public ushort DefaultPercentageVAT { get; set; }
    }
}