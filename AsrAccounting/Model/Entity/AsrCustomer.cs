namespace AsrAccounting.Model.Entity {
    public class AsrCustomer {
        private int id;
        private string name;
        private string company;
        private string address;
        private string city;
        private string zip;

        public int Id {
            get {
                return id;
            }

            set {
                id = value;
            }
        }

        public string Name {
            get {
                return name;
            }

            set {
                name = value;
            }
        }

        public string Company {
            get {
                return company;
            }

            set {
                company = value;
            }
        }

        public string Address {
            get {
                return address;
            }

            set {
                address = value;
            }
        }

        public string City {
            get {
                return city;
            }

            set {
                city = value;
            }
        }

        public string Zip {
            get {
                return zip;
            }

            set {
                zip = value;
            }
        }
    }
}
