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
        /// An amount which is filled by default
        /// </summary>
        public decimal DefaultAmount { get; set; }        
    }
}
