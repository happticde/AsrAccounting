namespace AsrAccounting.Model.Entity {

    /// <summary>
    /// Customer class to save information of customer
    /// </summary>
    public class Customer {

        /// <summary>
        /// Unique Id of a customer
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// First name of the customer
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the customer 
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Name of the company if any
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// Stores address information
        /// </summary>
        public Address Address { get; set; }
    }
}
