namespace AsrAccounting.Model.Entity {

    /// <summary>
    /// Global address class to save address information
    /// </summary>
    public class Address {

        /// <summary>
        /// Unique Id of address information
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the street
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// House number of address, possibly with additional information
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Optional additional information of the address
        /// </summary>
        public string AdditionalInformation { get; set; }

        /// <summary>
        /// Post code or ZIP of address
        /// </summary>
        public string PostCode { get; set; }

        /// <summary>
        /// Name of the city
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// ISO-2 country code
        /// </summary>
        public string CountryCode { get; set; }
    }
}
