namespace AsrAccounting.Model.Entity {
    public class AsrLineAction {
        private int id;
        private string description;

        public int Id {
            get {
                return id;
            }

            set {
                id = value;
            }
        }

        public string Description {
            get {
                return description;
            }

            set {
                description = value;
            }
        }
    }
}
