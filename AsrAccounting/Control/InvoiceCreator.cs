using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using AsrAccounting.Model.Entity;
using System;
using System.Globalization;

namespace AsrAccounting.Control {
    public class InvoiceCreator {
        private AsrInvoice invoice;
        private PdfContentByte contentByte;

        public InvoiceCreator(AsrInvoice invoice) {
            Invoice = invoice;
        }

        public AsrInvoice Invoice {
            get {
                return invoice;
            }

            set {
                invoice = value;
            }
        }

        public void GeneratePdf() {
            Document doc = new Document(PageSize.A4, 10, 10, 42, 35);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("test.pdf", FileMode.Create));

            doc.Open();

            contentByte = writer.DirectContent;

            BaseFont font = BaseFont.CreateFont(
                "c:\\windows\\fonts\\calibri.ttf", 
                BaseFont.CP1250,
                BaseFont.NOT_EMBEDDED
            );

            writeTextCenter(
                "Autoservice Rötha",
                font,
                24,
                PageSize.A4.Width / 2,
                PageSize.A4.Height - 50
            );

            writeTextCenter(
                "Lackierung Autoglas",
                font,
                14,
                PageSize.A4.Width / 2,
                PageSize.A4.Height - 65
            );

            writeTextRight(
                "Inhaber: Folco Kahnt",
                font,
                12,
                PageSize.A4.Width - 40,
                PageSize.A4.Height - 80
            );

            writeTextRight(
                "Heinestr. 2a",
                font,
                12,
                PageSize.A4.Width - 40,
                PageSize.A4.Height - 90
            );

            writeTextRight(
                "04571 Rötha",
                font,
                12,
                PageSize.A4.Width - 40,
                PageSize.A4.Height - 100
            );

            doc.Close();
        }

        private PdfPTable createInvoiceTable() {
            PdfPTable table = new PdfPTable(4);
            float[] widths = new float[] { 6f, 1f, 1.5f, 1.5f };
            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture("de-DE");

            table.SetWidths(widths);
            table.SpacingBefore = 5f;
            table.SpacingAfter = 20f;

            table.AddCell("Beschreibung");
            table.AddCell("Menge");
            table.AddCell("Preis");
            table.AddCell("Gesamt");

            foreach(AsrInvoiceLine line in invoice.InvoiceLines) {
                PdfPCell descriptionCell = new PdfPCell();
                table.AddCell(Convert.ToString(line.Quantity));
                table.AddCell(line.UnitPrice.ToString("C", cultureInfo));
                table.AddCell(line.LineAmount.ToString("C", cultureInfo));
            }

            return table;
        }

        private void writeText(string text, float x, float y, int align) {
            this.contentByte.BeginText();
            this.contentByte.ShowTextAligned(
                align,
                text,
                x,
                y,
                0
            );
            this.contentByte.EndText();
        }

        private void writeTextLeft(string text, BaseFont font, int fontSize, float x, float y) {
            this.contentByte.SetFontAndSize(font, fontSize);
            this.writeText(text, x, y, PdfContentByte.ALIGN_LEFT);
        }

        private void writeTextRight(string text, BaseFont font, int fontSize, float x, float y) {
            this.contentByte.SetFontAndSize(font, fontSize);
            this.writeText(text, x, y, PdfContentByte.ALIGN_RIGHT);
        }

        private void writeTextCenter(string text, BaseFont font, int fontSize, float x, float y) {
            this.contentByte.SetFontAndSize(font, fontSize);
            this.writeText(text, x, y, PdfContentByte.ALIGN_CENTER);
        }
    }
}
