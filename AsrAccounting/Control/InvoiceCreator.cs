using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using AsrAccounting.Model.Entity;

namespace AsrAccounting.Control {
    public class InvoiceCreator {
        private AsrInvoice invoice;

        public InvoiceCreator(AsrInvoice invoice) {
            this.Invoice = invoice;
        }

        public AsrInvoice Invoice {
            get {
                return invoice;
            }

            set {
                invoice = value;
            }
        }

        public void generatePdf() {
            Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 42, 35);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("test.pdf", FileMode.Create));

            doc.Open();
            doc.Add(new Paragraph(this.Invoice.Customer.Name));
            doc.Add(new Paragraph(this.Invoice.Customer.Address));
            doc.Add(new Paragraph(this.Invoice.Customer.Zip + this.Invoice.Customer.City));
            doc.Add(new Paragraph(this.Invoice.Customer.Company));

            doc.Close();
        }
    }
}
