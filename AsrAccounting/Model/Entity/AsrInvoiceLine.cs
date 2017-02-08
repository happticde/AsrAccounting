namespace AsrAccounting.Model.Entity {
    public class AsrInvoiceLine {
        private int id;
        private AsrLineAction lineAction;
        private int quantity;
        private double unitPrice;
        private double lineAmount;

        public int Id {
            get {
                return id;
            }

            set {
                id = value;
            }
        }

        public AsrLineAction LineAction {
            get {
                return lineAction;
            }

            set {
                lineAction = value;
            }
        }

        public int Quantity {
            get {
                return quantity;
            }

            set {
                quantity = value;
            }
        }

        public double UnitPrice {
            get {
                return unitPrice;
            }

            set {
                unitPrice = value;
            }
        }

        public double LineAmount {
            get {
                return lineAmount;
            }

            set {
                lineAmount = value;
            }
        }
    }
}
